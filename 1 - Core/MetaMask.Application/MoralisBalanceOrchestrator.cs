using MRQ.CryptoBot.Domain.Adapter.Moralis;
using MRQ.CryptoBot.Domain.Business;
using MRQ.CryptoBot.Domain.Orchestrator;

namespace MRQ.CryptoBot.Orchestrator
{
    public class MoralisBalanceOrchestrator : IMoralisBalanceOrchestrator
    {
        readonly IMoralisBalanceBusiness _moralisBalanceBusiness;

        public MoralisBalanceOrchestrator(IMoralisBalanceBusiness moralisBalanceBusiness)
        {
            _moralisBalanceBusiness = moralisBalanceBusiness;
        }

        public async Task<BalanceDto> GetTokenBalance(string token)
        {
            return await _moralisBalanceBusiness.GetTokenBalance(token);
        }
    }
}