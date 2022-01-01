using MetaMask.Domain.Business;
using MetaMask.Domain.Orchestrator;

namespace MetaMask.Orchestrator
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