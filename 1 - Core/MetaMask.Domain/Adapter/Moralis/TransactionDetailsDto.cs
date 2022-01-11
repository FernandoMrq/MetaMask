namespace MRQ.CryptoBot.Domain.Adapter.Moralis
{
    public class TransactionDetailsDto
    {
        public string? hash { get; set; }
        public string? nonce { get; set; }
        public string? transaction_index { get; set; }
        public string? from_address { get; set; }
        public string? to_address { get; set; }
        public string? value { get; set; }
        public string? gas { get; set; }
        public string? gas_price { get; set; }
        public string? input { get; set; }
        public string? receipt_cumulative_gas_used { get; set; }
        public string? receipt_gas_used { get; set; }
        public object? receipt_contract_address { get; set; }
        public object? receipt_root { get; set; }
        public string? receipt_status { get; set; }
        public DateTime? block_timestamp { get; set; }
        public string? block_number { get; set; }
        public string? block_hash { get; set; }
        public List<LogOfHashDto>? logs { get; set; }
    }
}
