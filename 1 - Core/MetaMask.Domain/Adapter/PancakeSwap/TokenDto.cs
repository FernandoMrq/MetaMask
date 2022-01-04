namespace MRQ.CryptoBot.Domain.Adapter.PancakeSwap
{
    public class TokenDto
    {
        public string? Adress { get; set; }
        public string? Name { get; set; }
        public decimal BalanceBNB { get; set; }
        public decimal BalanceWei { get; set; }
    }
}
