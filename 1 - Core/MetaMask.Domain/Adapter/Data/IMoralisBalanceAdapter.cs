using MRQ.CryptoBot.Domain.Adapter.Moralis;

namespace MRQ.CryptoBot.Domain.Adapter.Data
{
    public interface IMoralisBalanceAdapter
    {
        public Task<BalanceDto> GetTokenFromMoralis(string token);
    }
}
