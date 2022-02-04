namespace MRQ.CryptoBot.Domains.Entities.Moralis
{
    public class Balance
    {
        public int Id { get; set; }
        public Decimal UsdPrice { get; set; }
        public string? ExchangeAddress { get; set; }
        public string? ExchangeName { get; set; }
    }
}
