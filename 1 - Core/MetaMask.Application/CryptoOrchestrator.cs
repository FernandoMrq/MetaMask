using MRQ.CryptoBot.Domain.Business;
using MRQ.CryptoBot.Domain.Orchestrator;

namespace MRQ.CryptoBot.Orchestrator
{
    public class CryptoOrchestrator : ICryptoOrchestrator
    {
        readonly IChromeBusiness _chromeBusiness;

        public CryptoOrchestrator(IChromeBusiness chromeBusiness)
        {
            _chromeBusiness = chromeBusiness;
        }

        public void GetTokenBalance(string token)
        {
            throw new NotImplementedException();
        }
    }
}