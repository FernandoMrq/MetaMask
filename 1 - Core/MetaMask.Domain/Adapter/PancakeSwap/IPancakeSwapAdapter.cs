using MRQ.ReturnContent;

namespace MRQ.CryptoBot.Domains.Adapter.PancakeSwap
{
    public interface IBlockChainOperationAdapter
    {
        public Task GetWalletBalanceOfTokenAsync(WalletDto walletDto, TokenDto tokenDto);
        public Task<Returned> SwapTokensAsync(WalletDto walletDto, TokenDto tokenOrigin, TokenDto tokenDestination);
        public Task<Returned> SendToWalletAsync(WalletDto walletOrigem, WalletDto walletDestino, TokenDto tokenOrigem);
    }
}
