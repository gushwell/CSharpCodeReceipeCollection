using Microsoft.EntityFrameworkCore;

namespace Gihyo
{

    public class ExampleDbContext : DbContext
    {
        // ソースコード簡略化のため、直接接続文字列を指定しているいる
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=example.db");

        public DbSet<Novel> Novels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Novel>()
                   .Property(e => e.Category)
                   .HasConversion<string>()
                   .HasMaxLength(10);
        }
    }
}