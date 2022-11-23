using Microsoft.EntityFrameworkCore;


namespace Gihyo
{

    public class ExampleDbContext : DbContext
    {
        public ExampleDbContext(DbContextOptions<ExampleDbContext> options)
            : base(options)
        {
        }
        public DbSet<Novel> Novels { get; set; }
    }
}