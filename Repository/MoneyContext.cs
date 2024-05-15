using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace Repository
{
    public class MoneyContext : DbContext
    {
        public DbSet<MoneyTotal> MoneyTotals { get; set; }
        public DbSet<MoneyLog> MoneyLogs { get; set; }

        public string DbPath { get; }

        public MoneyContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "money.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    }
}
