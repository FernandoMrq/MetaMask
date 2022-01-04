using MRQ.CryptoBot.Domain.Adapter.Data;
using MRQ.CryptoBot.Domain.Adapter.Moralis;
using MRQ.CryptoBot.Domain.Adapter.PancakeSwap;
using MRQ.CryptoBot.Domain.Business;

namespace MRQ.CryptoBot.Business
{
    public class MoralisBalanceBusiness : IMoralisBalanceBusiness
    {
        readonly IMoralisBalanceAdapter _moralisBalanceAdapter;
        readonly IPancakeSwapAdapter _pancakeSwapAdapter;

        public MoralisBalanceBusiness(IMoralisBalanceAdapter moralisBalanceAdapter, IPancakeSwapAdapter pancakeSwapAdapter)
        {
            _moralisBalanceAdapter = moralisBalanceAdapter;
            _pancakeSwapAdapter = pancakeSwapAdapter;
        }

        public Task GetBalanceOfToken(WalletDto walletDto)
        {
            return _pancakeSwapAdapter.GetBalanceOfToken(walletDto);
        }

        public async Task<BalanceDto> GetTokenBalance(string token)
        {
            return await _moralisBalanceAdapter.GetTokenFromMoralis(token);
        }
    }
}