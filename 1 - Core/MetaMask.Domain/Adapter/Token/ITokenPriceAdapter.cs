using MRQ.CryptoBot.Domain.Adapter.PancakeSwap;
using MRQ.ReturnContent;

namespace MRQ.CryptoBot.Domain.Adapter.Token
{
    public interface ITokenPriceAdapter
    {
        public Task<Returned> GetTokenFromMoralis(TokenDto tokenDtoOrigin);
        public Task<Returned> GetWalletBalanceDefault(WalletDto wallet);
        public Task<Returned> GetWalletBalance(WalletDto wallet);
        public Task<Returned> GetTransactionDetails(string hashTransaction);
    }
}
