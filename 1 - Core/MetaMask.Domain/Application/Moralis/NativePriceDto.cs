namespace MRQ.CryptoBot.Domain.Application.Moralis
{
    public class NativePriceDto
    {
        public int Id { get; set; }
        public string? Value { get; set; }
        public int? Decimals { get; set; }
        public string? Name { get; set; }
        public string? Symbol { get; set; }
        public BalanceDto Balance { get; set; }
    }
}
