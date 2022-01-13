using MRQ.CryptoBot.Domain.Adapter.PancakeSwap;
using MRQ.ReturnContent;

namespace MRQ.CryptoBot.Domain.Business
{
    public interface ITokenPriceBusiness
    {
        public Task<Returned> GetTokenPrice(TokenDto tokenDtoOrigin);
    }
}
