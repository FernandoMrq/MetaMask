using MRQ.CryptoBot.Domain.Adapter.Moralis;

namespace MRQ.CryptoBot.Domain.Orchestrator
{
    public interface IMoralisBalanceOrchestrator
    {
        public Task<BalanceDto> GetTokenBalance(string token);

    }
}
