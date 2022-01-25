using MRQ.CryptoBot.Domain.Adapter.Moralis;
using System.Numerics;

namespace MRQ.CryptoBot.Domain.Adapter.PancakeSwap
{
    public static class ConfigurationDto
    {
        //PancakeSwap
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
        //Mudar para objeto com duas propriedades, ordem, token e routname ||-->> Ao adicionar na tela adicionar como tabela
        public static IList<string>? RoutersForSwaps { get; set; }



        //Moralis
        public static string? KeyName { get; set; }
        public static ChainType ChainType { get; set; }
        //Ao adicionar na tela adicionar como tabela
        public static IList<string>? MoralisApiKeys { get; set; }



        //Automation
        public static int TimeForPingConnectionWithInternet { get; set; }
        public static int TimeForPingConnectionWithWeb3 { get; set; }
        public static int TimeBetweenPriceUpdate { get; set; }
        public static int TimeBetweenWalletBalanceUpdate { get; set; }
    }
}
