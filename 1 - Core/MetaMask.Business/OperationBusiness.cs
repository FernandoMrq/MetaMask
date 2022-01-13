using MRQ.CryptoBot.Domain.Adapter.Moralis;
using MRQ.CryptoBot.Domain.Adapter.PancakeSwap;
using MRQ.CryptoBot.Domain.Adapter.Token;
using MRQ.CryptoBot.Domain.Business;
using MRQ.ReturnContent;

namespace MRQ.CryptoBot.Business
{
    public class OperationBusiness : IOperationBusiness
    {
        private readonly ITokenPriceAdapter _moralisBalanceAdapter;
        private readonly IBlockChainOperationAdapter _pancakeSwapAdapter;
        private readonly Returned _returned;

        public OperationBusiness(ITokenPriceAdapter moralisBalanceAdapter, IBlockChainOperationAdapter pancakeSwapAdapter)
        {
            _moralisBalanceAdapter = moralisBalanceAdapter;
            _pancakeSwapAdapter = pancakeSwapAdapter;
            _returned = ReturnedExtension.CreateReturned();
        }

        public async Task<Returned> GetTransactionDetails(string hashTransaction)
        {
            return await _moralisBalanceAdapter.GetTransactionDetails(hashTransaction);
        }

        public async Task<Returned> SendToWalletAsync(WalletDto walletOrigem, WalletDto walletDestino, TokenDto tokenOrigem)
        {
            return await _pancakeSwapAdapter.SendToWalletAsync(walletOrigem, walletDestino, tokenOrigem);
        }

        public async Task<Returned> SwapTokensAsync(WalletDto walletDto, TokenDto tokenOrigin, TokenDto tokenDestination)
        {
            //TODO Acertar validações
            await _pancakeSwapAdapter.GetWalletBalanceOfTokenAsync(walletDto, tokenOrigin);
            var tokenOriginPrice = (PriceOfTokenDto)(await _moralisBalanceAdapter.GetTokenFromMoralis(tokenOrigin)).Object;
            var tokenDestinationPrice = (PriceOfTokenDto)(await _moralisBalanceAdapter.GetTokenFromMoralis(tokenDestination)).Object;

            if (decimal.Parse(tokenOrigin.Balance) < decimal.Parse(tokenOrigin.Balance))
                _returned.InsertLogMessage("TokenPriceBusiness - Quantidade origem menor que o valor real", true);

            tokenDestination.Balance = ((tokenOriginPrice.UsdPrice * decimal.Parse(tokenOrigin.Balance)) / tokenDestinationPrice.UsdPrice).ToString();

            return await _pancakeSwapAdapter.SwapTokensAsync(walletDto, tokenOrigin, tokenDestination);
        }
    }
}
