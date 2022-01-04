using MRQ.CryptoBot.Domain.Adapter.Moralis;
using MRQ.CryptoBot.Domain.Adapter.PancakeSwap;

namespace MRQ.CryptoBot.Domain.Orchestrator
{
    public interface IMoralisBalanceOrchestrator
    {
        public Task<BalanceDto> GetTokenBalance(string token);
        public Task GetBalanceOfToken(WalletDto walletDto);

    }
}
