using Microsoft.EntityFrameworkCore;
using MRQ.CryptoBot.Domain.Adapter.Moralis;

namespace MetaMask.Repository.SQLite
{
    public class SQLiteContext : DbContext
    {
        public SQLiteContext(DbContextOptions<SQLiteContext> options) : base(options) { }
        public DbSet<Balance>? Balances { get; set; }
    }

}
