namespace MRQ.CryptoBot.Domain.Adapter.Moralis
{
    public class BalanceOfWalletTokenDto
    {
        public string? TokenAddress { get; set; }
        public string? Name { get; set; }
        public string? Symbol { get; set; }
        public object? Logo { get; set; }
        public object? Thumbnail { get; set; }
        public string? Decimals { get; set; }
        public string? Balance { get; set; }
    }
}