using Microsoft.VisualBasic;
using MRQ.CryptoBot.Domain.Adapter.Moralis;
using MRQ.CryptoBot.Domain.Adapter.PancakeSwap;
using MRQ.CryptoBot.Domain.Adapter.Token;
using MRQ.CryptoBot.Domain.Application.Configurations;
using MRQ.ReturnContent;
using System.Numerics;
using System.Text.Json;

namespace MRQ.CryptoBot.Integration.Moralis
{
    public class MoralisTokenPriceAdapter : ITokenPriceAdapter
    {
        private readonly HttpClient? _httpClient;
        private readonly JsonSerializerOptions? _jsonSerializerOptions;
        private readonly Returned _returned;



        public MoralisTokenPriceAdapter(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _returned = ReturnedExtension.CreateReturned();
            _jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };


            //TODO configurations não são setadas na mão, devem vir do banco
            ConfigurationDto.MoralisApiKeys = new List<string>();
            ConfigurationDto.KeyName = "X-API-Key";

            ConfigurationDto.MoralisApiKeys?.Add("jQWrwqiGwAWFhgQEDMiONpkTDU360LPjJfjvNiTvjDkHaFoF4KXKzgsMc5DSF7hd");
            ConfigurationDto.MoralisApiKeys?.Add("DzlA8wTqt5Ui5yPFIPqgUw7uiabsFKGjFAML2p8lvPKYii6wZ2M3fi98WFRfHjEL");
            ConfigurationDto.ChainType = ChainType.bsc;
        }

        private void AssignMoralisHeader()
        {
            if (_httpClient is null)
                return;

            if (ConfigurationDto.KeyName == null)
                return;

            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add(ConfigurationDto.KeyName, ConfigurationDto.MoralisApiKeys?.NextOf());
        }

        public async Task<Returned> GetTokenFromMoralis(TokenDto tokenDtoOrigin)
        {
            ReturnedExtension.CleanReturned(_returned);
            ReturnedExtension.InsertLogMessage(_returned, "MoralisTokenPriceAdapter - Inicio Busca Token Price");

            if (_httpClient is null)
                return _returned;

            AssignMoralisHeader();

            var response = await _httpClient.GetAsync(string.Format(IntegrationResource.PathPrice, tokenDtoOrigin.Adress, ConfigurationDto.ChainType));

            if (_jsonSerializerOptions is null)
                return _returned;

            if (response is null)
                return _returned;

            _returned.Object = JsonSerializer.Deserialize<PriceOfTokenDto>(await response.Content.ReadAsStringAsync(), _jsonSerializerOptions);

            ReturnedExtension.InsertLogMessage(_returned, "MoralisTokenPriceAdapter - Fim Busca Token Price");
            ReturnedExtension.AlterReturnedState(_returned, State.OK);

            return _returned;
        }

        public async Task<Returned> GetWalletBalanceDefault(WalletDto wallet)
        {
            ReturnedExtension.CleanReturned(_returned);
            ReturnedExtension.InsertLogMessage(_returned, "MoralisTokenPriceAdapter - Inicio recupera balance wallet default");

            if (_httpClient is null)
                return _returned;

            AssignMoralisHeader();

            var response = await _httpClient.GetAsync(string.Format(IntegrationResource.PathWalletBalanceDefault, wallet.Adress, ConfigurationDto.ChainType));

            if (_jsonSerializerOptions is null)
                return _returned;

            if (response is null)
                return _returned;

            _returned.Object = JsonSerializer.Deserialize<BalanceOfWalletTokenDefaultDto>(await response.Content.ReadAsStringAsync(), _jsonSerializerOptions);

            ReturnedExtension.InsertLogMessage(_returned, "MoralisTokenPriceAdapter - Fim recupera balance wallet default");
            ReturnedExtension.AlterReturnedState(_returned, State.OK);

            return _returned;
        }

        public async Task<Returned> GetWalletBalance(WalletDto wallet)
        {
            ReturnedExtension.CleanReturned(_returned);
            ReturnedExtension.InsertLogMessage(_returned, "MoralisTokenPriceAdapter - Inicio recupera balance wallet");

            if (_httpClient is null)
                return _returned;

            AssignMoralisHeader();

            var response = await _httpClient.GetAsync(string.Format(IntegrationResource.PathWalletBalance, wallet.Adress, ConfigurationDto.ChainType));

            if (_jsonSerializerOptions is null)
                return _returned;

            if (response is null)
                return _returned;

            _returned.Object = JsonSerializer.Deserialize<List<BalanceOfWalletTokenDto>>(await response.Content.ReadAsStringAsync());

            ReturnedExtension.InsertLogMessage(_returned, "MoralisTokenPriceAdapter - Fim recupera balance wallet");
            ReturnedExtension.AlterReturnedState(_returned, State.OK);

            return _returned;
        }

        public async Task<Returned> GetTransactionDetails(string hashTransaction)
        {
            ReturnedExtension.CleanReturned(_returned);
            ReturnedExtension.InsertLogMessage(_returned, "MoralisTokenPriceAdapter - Inicio recupera o status da transação");

            if (_httpClient is null)
                return _returned;

            AssignMoralisHeader();

            var response = await _httpClient.GetAsync(string.Format(IntegrationResource.PathTransactionState, hashTransaction, ConfigurationDto.ChainType));

            if (_jsonSerializerOptions is null)
                return _returned;

            if (response is null)
                return _returned;

            _returned.Object = JsonSerializer.Deserialize<TransactionDetailsDto>(await response.Content.ReadAsStringAsync());

            ReturnedExtension.InsertLogMessage(_returned, "MoralisTokenPriceAdapter - Fim recupera o status da transação");
            ReturnedExtension.AlterReturnedState(_returned, State.OK);

            return _returned;
        }

        public async Task<Returned> GetWalletBalanceOfTokenAsync(WalletDto walletDto, TokenDto tokenDto)
        {
            ReturnedExtension.CleanReturned(_returned);
            ReturnedExtension.InsertLogMessage(_returned, "MoralisTokenPriceAdapter - Inicio recupera balance of token in wallet");

            if (_httpClient is null)
                return _returned;

            var returnedBalance = await GetWalletBalance(walletDto);

            if (returnedBalance.Object is null)
                return _returned;

            var balance = (List<BalanceOfWalletTokenDto>)returnedBalance.Object;

            var token = balance.Where(b => b.token_address == tokenDto.Adress).FirstOrDefault();

            if (token == null)
                return _returned;

            tokenDto.BalanceWei = token.balance;
            tokenDto.Decimals = token.decimals;

            tokenDto.Balance = FromWei(tokenDto.BalanceWei, tokenDto.Decimals);
            tokenDto.Name = token.name;


            ReturnedExtension.InsertLogMessage(_returned, "MoralisTokenPriceAdapter - Fim recupera balance of token in wallet");
            ReturnedExtension.AlterReturnedState(_returned, State.OK);

            return _returned;
        }

        private string FromWei(string? value, string? decimalsNumber)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(decimalsNumber))
                return string.Empty;

            if (!BigInteger.TryParse(value, out var resultValue) || !int.TryParse(decimalsNumber, out var resultDecimals))
                return string.Empty;

            string resultAndDecimals = string.Concat(string.Concat(Enumerable.Repeat("0", resultDecimals)), resultValue);

            var rightResultAndDecimals = Strings.Right(resultAndDecimals, resultDecimals);

            var leftResultAndDecimals = Strings.Left(resultAndDecimals, resultAndDecimals.Length - resultDecimals);

            long.TryParse(leftResultAndDecimals, out long convertedResultAndDecimals);

            return string.Concat(convertedResultAndDecimals.ToString(), ",", rightResultAndDecimals);
        }

    }
}
