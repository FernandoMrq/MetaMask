namespace MRQ.CryptoBot.Domains.Adapter.Moralis
{
    public class LogOfHashDto
    {
        //TODO acertar de snake_case para CamelCase
        public string? log_index { get; set; }
        public string? transaction_hash { get; set; }
        public string? transaction_index { get; set; }
        public string? address { get; set; }
        public string? data { get; set; }
        public string? topic0 { get; set; }
        public string? topic1 { get; set; }
        public string? topic2 { get; set; }
        public object? topic3 { get; set; }
        public DateTime? block_timestamp { get; set; }
        public string? block_number { get; set; }
        public string? block_hash { get; set; }
    }
}
