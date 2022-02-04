using MRQ.CryptoBot.Domains.Adapter.PancakeSwap;
using MRQ.CryptoBot.Domains.Application;
using MRQ.CryptoBot.Domains.Business;
using MRQ.ReturnContent;

namespace MRQ.CryptoBot.Applications
{
    public class TokenPriceApplication : ITokenPriceApplication
    {
        readonly ITokenPriceBusiness _tokenPriceBusiness;
        readonly IWalletBalanceBusiness _walletBalanceBusiness;
        readonly IOperationBusiness _operationBusiness;

        public TokenPriceApplication(ITokenPriceBusiness moralisBalanceBusiness, IWalletBalanceBusiness walletBalanceBusiness, IOperationBusiness operationBusiness)
        {
            _tokenPriceBusiness = moralisBalanceBusiness;
            _walletBalanceBusiness = walletBalanceBusiness;
            _operationBusiness = operationBusiness;
        }

        public Task GetWalletBalanceOfToken(WalletDto walletDto, TokenDto tokenDto)
        {
            return _walletBalanceBusiness.GetWalletBalanceOfToken(walletDto, tokenDto);
        }

        public async Task<Returned> GetTokenPrice(TokenDto tokenDtoOrigin)
        {
            return await _tokenPriceBusiness.GetTokenPrice(tokenDtoOrigin);
        }

        public async Task<Returned> SwapTokensAsync(WalletDto walletDto, TokenDto tokenOrigin, TokenDto tokenDestination)
        {
            return await _operationBusiness.SwapTokensAsync(walletDto, tokenOrigin, tokenDestination);
        }

        public async Task<Returned> SendToWalletAsync(WalletDto walletOrigem, WalletDto walletDestino, TokenDto tokenOrigem)
        {
            return await _operationBusiness.SendToWalletAsync(walletOrigem, walletDestino, tokenOrigem);
        }

        public async Task<Returned> GetWalletBalanceDefault(WalletDto wallet)
        {
            return await _walletBalanceBusiness.GetWalletBalanceDefault(wallet);
        }

        public async Task<Returned> GetWalletBalance(WalletDto wallet)
        {
            return await _walletBalanceBusiness.GetWalletBalance(wallet);
        }

        public async Task<Returned> GetTransactionDetails(string hashTransaction)
        {
            return await _operationBusiness.GetTransactionDetails(hashTransaction);
        }
    }
}