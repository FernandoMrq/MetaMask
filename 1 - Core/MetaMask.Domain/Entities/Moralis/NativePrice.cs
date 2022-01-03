namespace MRQ.CryptoBot.Domain.Entities.Moralis
{
    public class NativePrice
    {
        public int Id { get; set; }
        public string? Value { get; set; }
        public int? Decimals { get; set; }
        public string? Name { get; set; }
        public string? Symbol { get; set; }
        public int BalanceId { get; set; }
    }
}
