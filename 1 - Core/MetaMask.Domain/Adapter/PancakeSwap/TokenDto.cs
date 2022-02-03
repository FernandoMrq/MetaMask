namespace MRQ.CryptoBot.Domains.Adapter.PancakeSwap
{
    public class TokenDto : TokenBaseDto
    {
        public string? Balance { get; set; }
        public string? BalanceWei { get; set; }
        public string? Decimals { get; set; }
    }
}
