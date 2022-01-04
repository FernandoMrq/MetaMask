using MRQ.CryptoBot.Domain.Adapter.Moralis;

namespace MRQ.CryptoBot.Domain.Business
{
    public interface IMoralisBalanceBusiness
    {
        public Task<BalanceDto> GetTokenBalance(string token);
    }
}
