namespace MRQ.CryptoBot.Domains.Entities
{
    public class Token
    {
        public int Id { get; set; }
        public string? Balance { get; set; }
        public string? BalanceWei { get; set; }
        public string? Decimals { get; set; }
    }
}
