namespace MRQ.CryptoBot.Domain.Adapter.Moralis
{
    public class LogOfHashDto
    {
        public string? LogIndex { get; set; }
        public string? TransactionHash { get; set; }
        public string? TransactionIndex { get; set; }
        public string? Address { get; set; }
        public string? Data { get; set; }
        public string? Topic0 { get; set; }
        public string? Topic1 { get; set; }
        public string? Topic2 { get; set; }
        public object? Topic3 { get; set; }
        public DateTime? BlockTimestamp { get; set; }
        public string? BlockNumber { get; set; }
        public string? BlockHash { get; set; }
    }
}
