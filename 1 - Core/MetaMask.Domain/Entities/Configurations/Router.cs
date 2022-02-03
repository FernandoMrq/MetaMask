namespace MRQ.CryptoBot.Domain.Entities.Configurations
{
    public class Router
    {
        public int Id { get; set; }
        public int SwapOrder { get; set; }
        public string Hash { get; set; } = "";
    }
}