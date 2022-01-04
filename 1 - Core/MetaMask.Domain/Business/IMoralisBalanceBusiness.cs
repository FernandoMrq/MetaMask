using MRQ.CryptoBot.Domain.Adapter.Moralis;
using MRQ.CryptoBot.Domain.Adapter.PancakeSwap;

namespace MRQ.CryptoBot.Domain.Business
{
    public interface IMoralisBalanceBusiness
    {
        public Task<BalanceDto> GetTokenBalance(string token);
        public Task GetBalanceOfToken(WalletDto walletDto);
    }
}
