namespace MRQ.CryptoBot.Domain.Adapter.Moralis
{
    public class TransactionDetailsDto
    {
        public string? Hash { get; set; }
        public string? Nonce { get; set; }
        public string? TransactionIndex { get; set; }
        public string? FromAddress { get; set; }
        public string? ToAddress { get; set; }
        public string? Value { get; set; }
        public string? Gas { get; set; }
        public string? GasPrice { get; set; }
        public string? Input { get; set; }
        public string? ReceiptCumulativeGasUsed { get; set; }
        public string? ReceiptGasUsed { get; set; }
        public object? ReceiptContractAddress { get; set; }
        public object? ReceiptRoot { get; set; }
        public string? ReceiptStatus { get; set; }
        public DateTime? BlockTimestamp { get; set; }
        public string? BlockNumber { get; set; }
        public string? BlockHash { get; set; }
        public List<LogOfHashDto>? Logs { get; set; }
    }
}
