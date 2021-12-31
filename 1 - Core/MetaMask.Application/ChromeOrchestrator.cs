using MetaMask.Domain.Business;
using MetaMask.Domain.Orchestrator;

namespace MetaMask.Orchestrator
{
    public class ChromeOrchestrator : IChromeOrchestrator
    {
        readonly IChromeBusiness _chromeBusiness;

        public ChromeOrchestrator(IChromeBusiness chromeBusiness)
        {
            _chromeBusiness = chromeBusiness;
        }

        public void ReturnChrome()
        {
            _chromeBusiness.ReturnChrome();
        }
    }
}