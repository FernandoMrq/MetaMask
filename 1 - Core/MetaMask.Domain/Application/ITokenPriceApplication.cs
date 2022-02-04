using MRQ.CryptoBot.Domains.Adapter.PancakeSwap;
using MRQ.ReturnContent;

namespace MRQ.CryptoBot.Domains.Application
{
    public interface ITokenPriceApplication
    {
        public Task<Returned> GetTokenPrice(TokenDto tokenDtoOrigin);
        public Task GetWalletBalanceOfToken(WalletDto walletDto, TokenDto token);
        public Task<Returned> SwapTokensAsync(WalletDto walletDto, TokenDto tokenOrigin, TokenDto tokenDestination);
        public Task<Returned> SendToWalletAsync(WalletDto walletOrigem, WalletDto walletDestino, TokenDto tokenOrigem);
        public Task<Returned> GetWalletBalanceDefault(WalletDto wallet);
        public Task<Returned> GetWalletBalance(WalletDto wallet);
        public Task<Returned> GetTransactionDetails(string hashTransaction);

    }
}
