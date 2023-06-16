global using Microsoft.EntityFrameworkCore;

namespace MinimalBookAPI
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=ASCNYC;database=MinimalAPI;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Book> Books => Set<Book>();

    }
}
