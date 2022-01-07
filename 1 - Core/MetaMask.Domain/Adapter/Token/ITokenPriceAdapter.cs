using MRQ.CryptoBot.Domain.Adapter.Moralis;

namespace MRQ.CryptoBot.Domain.Adapter.Token
{
    public interface ITokenPriceAdapter
    {
        public Task<PriceOfTokenDto> GetTokenFromMoralis(string token);
    }
}
