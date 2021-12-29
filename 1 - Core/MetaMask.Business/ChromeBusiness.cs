using MetaMask.Domain.Adapter;
using MetaMask.Domain.Business;

namespace MetaMask.Business
{
    public class ChromeBusiness : IChromeBusiness
    {
        IChromeAdapter _chromeAdapter;

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