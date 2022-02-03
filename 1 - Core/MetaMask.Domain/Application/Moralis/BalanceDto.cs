namespace MRQ.CryptoBot.Domain.Application.Moralis
{
    public class BalanceDto
    {
        public int Id { get; set; }
        public decimal UsdPrice { get; set; }
        public string? ExchangeAddress { get; set; }
        public string? ExchangeName { get; set; }
    }
}
