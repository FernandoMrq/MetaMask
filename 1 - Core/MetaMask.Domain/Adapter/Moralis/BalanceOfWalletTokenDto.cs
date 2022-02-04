namespace MRQ.CryptoBot.Domains.Adapter.Moralis
{
    public class BalanceOfWalletTokenDto
    {
        //TODO acertar de snake_case para CamelCase
        public string? token_address { get; set; }
        public string? name { get; set; }
        public string? symbol { get; set; }
        public object? logo { get; set; }
        public object? thumbnail { get; set; }
        public string? decimals { get; set; }
        public string? balance { get; set; }
    }
}