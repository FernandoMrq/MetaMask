namespace MRQ.CryptoBot.Domain.Adapter.PancakeSwap
{
    public class TokenDto : TokenBaseDto
    {
        public decimal Balance { get; set; }
        public decimal BalanceWei { get; set; }
    }
}
