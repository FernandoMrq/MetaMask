﻿using MRQ.CryptoBot.Domains.Adapter.PancakeSwap;
using MRQ.ReturnContent;

namespace MRQ.CryptoBot.Domains.Business
{
    public interface IOperationBusiness
    {
        public Task<Returned> SwapTokensAsync(WalletDto walletDto, TokenDto tokenOrigin, TokenDto tokenDestination);
        public Task<Returned> SendToWalletAsync(WalletDto walletOrigem, WalletDto walletDestino, TokenDto tokenOrigem);
        public Task<Returned> GetTransactionDetails(string hashTransaction);
    }
}
