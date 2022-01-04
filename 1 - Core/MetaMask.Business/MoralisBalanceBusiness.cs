using MRQ.CryptoBot.Domain.Adapter.Data;
using MRQ.CryptoBot.Domain.Adapter.Moralis;
using MRQ.CryptoBot.Domain.Business;

namespace MRQ.CryptoBot.Business
{
    public class MoralisBalanceBusiness : IMoralisBalanceBusiness
    {
        readonly IMoralisBalanceAdapter _moralisBalanceAdapter;

        public MoralisBalanceBusiness(IMoralisBalanceAdapter moralisBalanceAdapter)
        {
            _moralisBalanceAdapter = moralisBalanceAdapter;
        }

        public async Task<BalanceDto> GetTokenBalance(string token)
        {
            return await _moralisBalanceAdapter.GetTokenFromMoralis(token);
        }
    }
}