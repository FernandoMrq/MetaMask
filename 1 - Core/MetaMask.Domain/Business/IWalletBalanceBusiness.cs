using MRQ.CryptoBot.Domains.Adapter.PancakeSwap;
using MRQ.ReturnContent;

namespace MRQ.CryptoBot.Domains.Business
{
    public interface IWalletBalanceBusiness
    {
        public Task GetWalletBalanceOfToken(WalletDto walletDto, TokenDto token);
        public Task<Returned> GetWalletBalanceDefault(WalletDto wallet);
        public Task<Returned> GetWalletBalance(WalletDto wallet);
    }
}
