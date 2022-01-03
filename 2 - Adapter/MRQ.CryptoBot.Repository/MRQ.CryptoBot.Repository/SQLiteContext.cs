using Microsoft.EntityFrameworkCore;
using MRQ.CryptoBot.Domain.Entities.Moralis;

namespace MRQ.CryptoBot.Repository
{
    public class SQLiteContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=context.db"); //Melhorar essa parte
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Balance>().HasKey(b => b.Id);
            modelBuilder.Entity<NativePrice>().HasKey(b => b.Id);
        }

        public DbSet<Balance>? Balances { get; set; }
        public DbSet<NativePrice>? NativePrices { get; set; }
    }
}