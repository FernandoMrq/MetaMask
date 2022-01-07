using MRQ.CryptoBot.Domain.Adapter.Moralis;
using MRQ.CryptoBot.Domain.Adapter.PancakeSwap;
using MRQ.ReturnContent;

namespace MRQ.CryptoBot.Domain.Orchestrator
{
    public interface ITokenPriceOrchestrator
    {
        public Task<PriceOfToken> GetTokenPrice(string token);
        public Task GetWalletBalanceOfToken(WalletDto walletDto, TokenDto token);
        public Task<Returned> SwapTokensAsync(WalletDto walletDto, TokenDto tokenOrigin, TokenDto tokenDestination);
        public Task<Returned> SendToWalletAsync(WalletDto walletOrigem, WalletDto walletDestino, TokenDto tokenOrigem);

    }
}
