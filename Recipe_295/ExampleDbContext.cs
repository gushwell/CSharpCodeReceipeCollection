using Microsoft.EntityFrameworkCore;

namespace Gihyo
{

    public class ExampleDbContext : DbContext
    {
        // ソースコード簡略化のため、直接接続文字列を指定している
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=example.db");

        public DbSet<User> Users { get; set; }
    }
}