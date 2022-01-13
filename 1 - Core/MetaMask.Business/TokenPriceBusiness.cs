using MRQ.CryptoBot.Domain.Adapter.PancakeSwap;
using MRQ.CryptoBot.Domain.Adapter.Token;
using MRQ.CryptoBot.Domain.Business;
using MRQ.ReturnContent;

namespace MRQ.CryptoBot.Business
{
    public class TokenPriceBusiness : ITokenPriceBusiness
    {
        private readonly ITokenPriceAdapter _moralisBalanceAdapter;

        public TokenPriceBusiness(ITokenPriceAdapter moralisBalanceAdapter)
        {
            _moralisBalanceAdapter = moralisBalanceAdapter;
        }

        public async Task<Returned> GetTokenPrice(TokenDto tokenDtoOrigin)
        {
            return await _moralisBalanceAdapter.GetTokenFromMoralis(tokenDtoOrigin);
        }
    }
}