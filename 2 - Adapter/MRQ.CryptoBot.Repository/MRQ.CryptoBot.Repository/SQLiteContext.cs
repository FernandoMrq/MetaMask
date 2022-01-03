using Microsoft.EntityFrameworkCore;
using MRQ.CryptoBot.Domain.Entities.Moralis;

namespace MRQ.CryptoBot.Repository
{
    public class SQLiteContext : DbContext
    {
        //public SQLiteContext(DbContextOptions<SQLiteContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("context.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Balance>().HasKey(b => b.Id);
            modelBuilder.Entity<NativePrice>().HasKey(b => b.Id);

            //modelBuilder.Entity<Balance>().HasOne(b => b.NativePrice);
        }

        public DbSet<Balance>? Balances { get; set; }
        public DbSet<NativePrice>? NativePrices { get; set; }
    }
}