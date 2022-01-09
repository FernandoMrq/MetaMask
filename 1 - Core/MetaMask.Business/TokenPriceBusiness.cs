﻿using MRQ.CryptoBot.Domain.Adapter.Moralis;
using MRQ.CryptoBot.Domain.Adapter.PancakeSwap;
using MRQ.CryptoBot.Domain.Adapter.Token;
using MRQ.CryptoBot.Domain.Business;
using MRQ.ReturnContent;

namespace MRQ.CryptoBot.Business
{
    public class TokenPriceBusiness : ITokenPriceBusiness
    {
        readonly ITokenPriceAdapter _moralisBalanceAdapter;
        readonly IBlockChainOperationAdapter _pancakeSwapAdapter;
        readonly Returned _returned;

        public TokenPriceBusiness(ITokenPriceAdapter moralisBalanceAdapter, IBlockChainOperationAdapter pancakeSwapAdapter)
        {
            _moralisBalanceAdapter = moralisBalanceAdapter;
            _pancakeSwapAdapter = pancakeSwapAdapter;

            _returned = ReturnedExtension.CreateReturned();
        }

        public Task GetWalletBalanceOfToken(WalletDto walletDto, TokenDto tokenDto)
        {
            return _pancakeSwapAdapter.GetWalletBalanceOfTokenAsync(walletDto, tokenDto);
        }

        public async Task<Returned> GetTokenPrice(TokenDto tokenDtoOrigin)
        {
            return await _moralisBalanceAdapter.GetTokenFromMoralis(tokenDtoOrigin);
        }

        public async Task<Returned> SwapTokensAsync(WalletDto walletDto, TokenDto tokenOrigin, TokenDto tokenDestination)
        {
            //TODO Acertar validações
            await GetWalletBalanceOfToken(walletDto, tokenOrigin);
            var tokenOriginPrice = (PriceOfTokenDto)(await GetTokenPrice(tokenOrigin)).Object;
            var tokenDestinationPrice = (PriceOfTokenDto)(await GetTokenPrice(tokenDestination)).Object;

            if (tokenOrigin.Balance < tokenOrigin.Balance)
                _returned.InsertLogMessage("TokenPriceBusiness - Quantidade origem menor que o valor real", true);

            tokenDestination.Balance = ((tokenOriginPrice.UsdPrice * tokenOrigin.Balance) / tokenDestinationPrice.UsdPrice);

            return await _pancakeSwapAdapter.SwapTokensAsync(walletDto, tokenOrigin, tokenDestination);
        }

        public async Task<Returned> SendToWalletAsync(WalletDto walletOrigem, WalletDto walletDestino, TokenDto tokenOrigem)
        {
            return await _pancakeSwapAdapter.SendToWalletAsync(walletOrigem, walletDestino, tokenOrigem);
        }
    }
}