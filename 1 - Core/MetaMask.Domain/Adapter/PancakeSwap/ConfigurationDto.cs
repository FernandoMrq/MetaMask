using System.Numerics;

namespace MRQ.CryptoBot.Domain.Adapter.PancakeSwap
{
    public static class ConfigurationDto
    {
        private static decimal slippageTolerance;

        public static string? Web3Url { get; set; }
        public static IEnumerable<string>? MoralisApiKeys { get; set; }
        public static string? ContractABI { get; set; }
        public static string? RouterForSwap { get; set; }
        public static string? ToakenDefaultCOntract { get; set; }
        public static BigInteger GasPrice { get; set; }
        public static BigInteger Gas { get; set; }
        /// <summary>
        /// Double value of percentage. Withe 3% the value to SlippageTolerance will be 3.
        /// </summary>
        public static decimal SlippageTolerance
        {
            get => slippageTolerance;
            set => slippageTolerance = value > 0 ? (100 - value) / 100 : 1;
        }
    }
}
