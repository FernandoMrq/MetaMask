namespace MRQ.CryptoBot.Domain.Entities
{
    public class RoutersForSwap
    {
        public int Id { get; set; }
        public int ConfigurationId { get; set; }
        public int Priority { get; set; }
        public IEnumerable<Router>? Router { get; set; }
    }
}