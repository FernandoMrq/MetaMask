using MRQ.CryptoBot.Domain.Adapter;
using MRQ.CryptoBot.Domain.Business;

namespace MRQ.CryptoBot.Business
{
    public class ChromeBusiness : IChromeBusiness
    {
        readonly IChromeAdapter _chromeAdapter;

        public ChromeBusiness(IChromeAdapter chromeAdapter)
        {
            _chromeAdapter = chromeAdapter;
        }

        public void ReturnChrome()
        {
            _chromeAdapter.ReturnChrome();
        }
    }
}