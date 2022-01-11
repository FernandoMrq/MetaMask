namespace MRQ.CryptoBot.Domain.Adapter.Moralis
{
    public class BalanceOfWalletTokenDto
    {
        public string? token_address { get; set; }
        public string? name { get; set; }
        public string? symbol { get; set; }
        public object? logo { get; set; }
        public object? thumbnail { get; set; }
        public string? decimals { get; set; }
        public string? balance { get; set; }
    }
}