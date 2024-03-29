﻿using MRQ.CryptoBot.Domains.Adapter.Moralis;
using MRQ.CryptoBot.Domains.Entities.Moralis;

namespace MRQ.CryptoBot.Domains.Entities.Configurations
{
    public class Configuration
    {
        public int Id { get; set; }

        #region PancakeSwap


        public string? Web3Url { get; set; }
        public string? ContractABI { get; set; }

        /// <summary>
        /// Ex contrato da pancake
        /// </summary>
        public string? ContractRouterForSwap { get; set; }
        public string DefaultGasPrice { get; set; }
        public string DefaultGas { get; set; }
        public decimal SlippageTolerance { get; set; }
        public string? TokenDefaultContract { get; set; }

        //Mudar para objeto com tres propriedades, ordem, token e routname ||-->> Ao adicionar na tela adicionar como tabela
        public IList<RoutersForSwap>? RoutersForSwaps { get; set; }


        #endregion

        #region Moralis


        public string? KeyName { get; set; }
        public ChainType ChainType { get; set; }
        //Ao adicionar na tela adicionar como tabela
        public IList<ApiKey>? MoralisApiKeys { get; set; }


        #endregion

        #region Automation      


        public int TimeForPingConnectionWithInternet { get; set; }
        public int TimeForPingConnectionWithWeb3 { get; set; }
        public int TimeBetweenPriceUpdate { get; set; }
        public int TimeBetweenWalletBalanceUpdate { get; set; }


        #endregion
    }
}
