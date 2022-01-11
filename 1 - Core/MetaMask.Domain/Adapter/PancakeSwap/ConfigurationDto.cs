﻿using MRQ.CryptoBot.Domain.Adapter.Moralis;
using System.Numerics;

namespace MRQ.CryptoBot.Domain.Adapter.PancakeSwap
{
    public static class ConfigurationDto
    {
        public static string? Web3Url { get; set; }
        public static string? KeyName { get; set; }
        public static IList<string>? MoralisApiKeys { get; set; }
        public static string? ContractABI { get; set; }
        public static string? RouterForSwap { get; set; }
        public static string? ToakenDefaultCOntract { get; set; }
        public static BigInteger GasPrice { get; set; }
        public static BigInteger Gas { get; set; }
        public static decimal SlippageTolerance { get; set; }
        public static int TimeBetweenPriceUpdate { get; set; }
        public static int TimeBetweenWalletBalanceUpdate { get; set; }
        public static ChainType ChainType { get; set; }
    }
}
