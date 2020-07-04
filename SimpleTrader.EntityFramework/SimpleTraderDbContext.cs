using Microsoft.EntityFrameworkCore;
using SimpleTrade.Domain.Models;

namespace SimpleTrader.EntityFramework
{
    public class SimpleTraderDbContext : DbContext
    {
        
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetTransaction> AssetTransactions { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<User> Users { get; set; }

        public SimpleTraderDbContext(DbContextOptions options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SimpleTraderDB;Integrated Security=True;Pooling=False");

        //    base.OnConfiguring(optionsBuilder);
        //}



    }
}
