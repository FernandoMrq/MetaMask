using MRQ.CryptoBot.Domain.Adapter.Moralis;
using MRQ.CryptoBot.Domain.Adapter.PancakeSwap;
using MRQ.CryptoBot.Domain.Adapter.Token;
using MRQ.ReturnContent;
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
        }

        public async Task<Returned> GetTokenFromMoralis(TokenDto tokenDtoOrigin)
        {
            ReturnedExtension.CleanReturned(_returned);
            ReturnedExtension.InsertLogMessage(_returned, "MoralisTokenPriceAdapter - Inicio Busca Token Price");

            if (_httpClient is null)
                return _returned;

            _httpClient.DefaultRequestHeaders.Clear(); //TODO acertar os headers
            _httpClient.DefaultRequestHeaders.Add("X-API-Key", "jQWrwqiGwAWFhgQEDMiONpkTDU360LPjJfjvNiTvjDkHaFoF4KXKzgsMc5DSF7hd");
            var response = await _httpClient.GetAsync(string.Format(IntegrationResource.PathPrice, tokenDtoOrigin.Adress, ChainType.bsc));

            if (_jsonSerializerOptions is null)
                return _returned;

            if (response is null)
                return _returned;

            _returned.Object = JsonSerializer.Deserialize<PriceOfTokenDto>(await response.Content.ReadAsStringAsync(), _jsonSerializerOptions);

            ReturnedExtension.InsertLogMessage(_returned, "MoralisTokenPriceAdapter - Fim Busca Token Price");
            ReturnedExtension.AlterReturnedState(_returned, State.OK);

            return _returned;
        }


    }
}
