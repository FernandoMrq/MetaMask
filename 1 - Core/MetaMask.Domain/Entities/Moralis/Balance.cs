namespace MRQ.CryptoBot.Domain.Entities.Moralis
{
    public class Balance
    {
        public int Id { get; set; }
        public NativePrice? NativePrice { get; set; }
        public Decimal UsdPrice { get; set; }
        public string? ExchangeAddress { get; set; }
        public string? ExchangeName { get; set; }
    }
}
