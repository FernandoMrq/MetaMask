using Microsoft.EntityFrameworkCore;
using MRQ.CryptoBot.Domain.Application.Moralis;
using MRQ.CryptoBot.Domain.Entities;
using MRQ.CryptoBot.Domain.Entities.Configurations;
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
            modelBuilder.Entity<Wallet>().HasKey(b => b.Id);
            modelBuilder.Entity<Token>().HasKey(b => b.Id);
            modelBuilder.Entity<Configuration>().HasKey(b => b.Id);
            modelBuilder.Entity<RoutersForSwap>().HasKey(b => b.Id);
            modelBuilder.Entity<Router>().HasKey(b => b.Id);
            modelBuilder.Entity<ApiKey>().HasKey(b => b.Id);
        }

        public DbSet<Balance>? Balances { get; set; }
        public DbSet<NativePrice>? NativePrices { get; set; }
        public DbSet<Wallet>? Wallets { get; set; }
        public DbSet<Token>? Tokens { get; set; }
        public DbSet<Configuration>? Configurations { get; set; }
        public DbSet<RoutersForSwap>? RoutersForSwap { get; set; }
        public DbSet<Router>? Router { get; set; }
        public DbSet<ApiKey>? MoralisApiKey { get; set; }
    }
}