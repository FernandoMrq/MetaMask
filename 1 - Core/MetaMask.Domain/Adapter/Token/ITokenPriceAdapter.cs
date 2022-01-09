using MRQ.CryptoBot.Domain.Adapter.PancakeSwap;
using MRQ.ReturnContent;

namespace MRQ.CryptoBot.Domain.Adapter.Token
{
    public interface ITokenPriceAdapter
    {
        public Task<Returned> GetTokenFromMoralis(TokenDto tokenDtoOrigin);
    }
}
