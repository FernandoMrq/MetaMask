namespace MRQ.CryptoBot.Domain.Adapter.Moralis
{
    public class BalanceDto
    {
        public Decimal UsdPrice { get; set; }
        public string? ExchangeAddress { get; set; }
        public string? ExchangeName { get; set; }
        public NativePriceDto? NativePrice { get; set; }
    }
}
