using MRQ.CryptoBot.Domains.Adapter.PancakeSwap;
using MRQ.ReturnContent;

namespace MRQ.CryptoBot.Domains.Business
{
    public interface ITokenPriceBusiness
    {
        public Task<Returned> GetTokenPrice(TokenDto tokenDtoOrigin);
    }
}
