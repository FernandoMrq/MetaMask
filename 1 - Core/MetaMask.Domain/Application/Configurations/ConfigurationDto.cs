using MRQ.CryptoBot.Domains.Adapter.Moralis;
using MRQ.CryptoBot.Domains.Application.Moralis;
using System.Numerics;

namespace MRQ.CryptoBot.Domains.Application.Configurations
{
    public class ConfigurationDto
    {
        #region PancakeSwap


        public string? Web3Url { get; set; }
        public string? ContractABI { get; set; }

        /// <summary>
        /// Ex contrato da pancake
        /// </summary>
        public string? ContractRouterForSwap { get; set; }
        public BigInteger DefaultGasPrice { get; set; }
        public BigInteger DefaultGas { get; set; }
        public decimal SlippageTolerance { get; set; }
        public string? TokenDefaultContract { get; set; }

        //TODO Mudar para objeto com tres propriedades, ordem, token e routname ||-->> Ao adicionar na tela adicionar como tabela
        public IList<RoutersForSwapDto>? RoutersForSwaps { get; set; }


        #endregion

        #region Moralis


        public string? KeyName { get; set; }
        public ChainType ChainType { get; set; }

        //TODO Ao adicionar na tela adicionar como tabela
        //public  IList<MoralisApiKeyDto>? MoralisApiKeys { get; set; }
        public IList<ApiKeyDto>? MoralisApiKeys { get; set; }


        #endregion

        #region Automation      


        public int TimeForPingConnectionWithInternet { get; set; }
        public int TimeForPingConnectionWithWeb3 { get; set; }
        public int TimeBetweenPriceUpdate { get; set; }
        public int TimeBetweenWalletBalanceUpdate { get; set; }


        #endregion
    }
}
