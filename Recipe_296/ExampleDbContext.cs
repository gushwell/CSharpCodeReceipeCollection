using Microsoft.EntityFrameworkCore;

namespace Gihyo
{

    public class ExampleDbContext : DbContext
    {
        // ソースコード簡略化のため、直接接続文字列を指定している
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=example.db");

        public DbSet<User> Users { get; set; }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // UserテーブルのNameにIndexを指定
            modelBuilder.Entity<User>()
                .HasIndex(e => e.Name)
                .IsUnique();
            // PostテーブルのSentTimeにIndexを指定指定
            modelBuilder.Entity<Post>()
                .HasIndex(e => e.SentTime)
                .HasDatabaseName("Index_SentTime");
        }
    }
}