using MRQ.CryptoBot.Domains.Adapter.PancakeSwap;
using MRQ.CryptoBot.Domains.Adapter.Token;
using MRQ.CryptoBot.Domains.Business;
using MRQ.ReturnContent;

namespace MRQ.CryptoBot.Business
{
    public class WalletBalanceBusiness : IWalletBalanceBusiness
    {
        private readonly ITokenPriceAdapter _moralisBalanceAdapter;
        private readonly IBlockChainOperationAdapter _pancakeSwapAdapter;

        public WalletBalanceBusiness(ITokenPriceAdapter moralisBalanceAdapter, IBlockChainOperationAdapter pancakeSwapAdapter)
        {
            _moralisBalanceAdapter = moralisBalanceAdapter;
            _pancakeSwapAdapter = pancakeSwapAdapter;
        }
        public async Task<Returned> GetWalletBalance(WalletDto wallet)
        {
            return await _moralisBalanceAdapter.GetWalletBalance(wallet);
        }

        public async Task<Returned> GetWalletBalanceDefault(WalletDto wallet)
        {
            return await _moralisBalanceAdapter.GetWalletBalanceDefault(wallet);
        }

        public Task GetWalletBalanceOfToken(WalletDto walletDto, TokenDto tokenDto)
        {
            return _moralisBalanceAdapter.GetWalletBalanceOfTokenAsync(walletDto, tokenDto);
        }
    }
}
