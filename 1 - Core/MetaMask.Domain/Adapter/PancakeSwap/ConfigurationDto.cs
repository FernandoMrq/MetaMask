namespace MRQ.CryptoBot.Domain.Adapter.PancakeSwap
{
    public static class ConfigurationDto
    {
        public static string? Web3Url { get; set; }
        public static IEnumerable<string>? MoralisApiKeys { get; set; }
        public static string? ContractABI { get; set; }
    }
}
