﻿using MRQ.CryptoBot.Domains.Adapter.Moralis;
using System.Numerics;

namespace MRQ.CryptoBot.Domains.Application.Configurations
{
    public static class ConfigurationStaticDto
    {
        #region PancakeSwap


        public static string? Web3Url { get; set; }
        public static string? ContractABI { get; set; }

        /// <summary>
        /// Ex contrato da pancake
        /// </summary>
        public static string? ContractRouterForSwap { get; set; }
        public static BigInteger DefaultGasPrice { get; set; }
        public static BigInteger DefaultGas { get; set; }
        public static decimal SlippageTolerance { get; set; }
        public static string? TokenDefaultContract { get; set; }

        //TODO Mudar para objeto com tres propriedades, ordem, token e routname ||-->> Ao adicionar na tela adicionar como tabela
        public static IList<RoutersForSwapDto>? RoutersForSwaps { get; set; }


        #endregion

        #region Moralis


        public static string? KeyName { get; set; }
        public static ChainType ChainType { get; set; }

        //TODO Ao adicionar na tela adicionar como tabela
        //public static IList<MoralisApiKeyDto>? MoralisApiKeys { get; set; }
        public static IList<string>? MoralisApiKeys { get; set; }


        #endregion

        #region Automation      


        public static int TimeForPingConnectionWithInternet { get; set; }
        public static int TimeForPingConnectionWithWeb3 { get; set; }
        public static int TimeBetweenPriceUpdate { get; set; }
        public static int TimeBetweenWalletBalanceUpdate { get; set; }


        #endregion
    }
}
