namespace MRQ.CryptoBot.Domain.Entities
{
    public class RoutersForSwap
    {
        public int Id { get; set; }
        public int ConfigurationId { get; set; }
        public int Priority { get; set; }
        public IList<Router>? Router { get; set; }
    }
}