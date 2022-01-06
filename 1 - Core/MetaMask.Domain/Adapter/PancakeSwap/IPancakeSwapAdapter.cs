using MRQ.ReturnContent;

namespace MRQ.CryptoBot.Domain.Adapter.PancakeSwap
{
    public interface IBlockChainOperationAdapter
    {
        public Task GetWalletBalanceOfTokenAsync(WalletDto walletDto);
        public Task<Returned> SwapTokensAsync(WalletDto walletDto, TokenDto tokenOrigin, TokenDto tokenDestination);
        public Task<Returned> SendToWalletAsync(WalletDto walletOrigem, WalletDto walletDestino, TokenDto tokenOrigem);
    }
}
