namespace MRQ.CryptoBot.Domain.Adapter.PancakeSwap
{
    public interface IPancakeSwapAdapter
    {
        public Task GetBalanceOfToken(WalletDto walletDto);
    }
}
