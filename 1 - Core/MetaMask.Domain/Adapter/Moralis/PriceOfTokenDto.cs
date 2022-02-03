namespace MRQ.CryptoBot.Domains.Adapter.Moralis
{
    public class PriceOfTokenDto
    {
        public Decimal UsdPrice { get; set; }
        public string? ExchangeAddress { get; set; }
        public string? ExchangeName { get; set; }
        public NativePriceDto? NativePrice { get; set; }
    }
}
