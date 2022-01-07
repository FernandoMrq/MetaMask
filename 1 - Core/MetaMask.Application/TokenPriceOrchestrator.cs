using MRQ.CryptoBot.Domain.Adapter.Moralis;
using MRQ.CryptoBot.Domain.Adapter.PancakeSwap;
using MRQ.CryptoBot.Domain.Business;
using MRQ.CryptoBot.Domain.Orchestrator;
using MRQ.ReturnContent;

namespace MRQ.CryptoBot.Orchestrator
{
    public class TokenPriceOrchestrator : ITokenPriceOrchestrator
    {
        readonly ITokenPriceBusiness _tokenPriceBusiness;

        public TokenPriceOrchestrator(ITokenPriceBusiness moralisBalanceBusiness)
        {
            _tokenPriceBusiness = moralisBalanceBusiness;
        }

        public Task GetWalletBalanceOfToken(WalletDto walletDto, TokenDto tokenDto)
        {
            return _tokenPriceBusiness.GetWalletBalanceOfToken(walletDto, tokenDto);
        }

        public async Task<PriceOfTokenDto> GetTokenPrice(string token)
        {
            return await _tokenPriceBusiness.GetTokenPrice(token);
        }

        public async Task<Returned> SwapTokensAsync(WalletDto walletDto, TokenDto tokenOrigin, TokenDto tokenDestination)
        {
            return await _tokenPriceBusiness.SwapTokensAsync(walletDto, tokenOrigin, tokenDestination);
        }

        public async Task<Returned> SendToWalletAsync(WalletDto walletOrigem, WalletDto walletDestino, TokenDto tokenOrigem)
        {
            return await _tokenPriceBusiness.SendToWalletAsync(walletOrigem, walletDestino, tokenOrigem);
        }
    }
}