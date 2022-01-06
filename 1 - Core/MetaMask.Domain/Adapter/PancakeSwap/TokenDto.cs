namespace MRQ.CryptoBot.Domain.Adapter.PancakeSwap
{
    public class TokenDto
    {
        public string? Adress { get; set; }
        public string? Name { get; set; }
        public decimal Balance { get; set; }
        public decimal BalanceWei { get; set; }
    }
}
