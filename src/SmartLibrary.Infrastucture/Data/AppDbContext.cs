using Microsoft.EntityFrameworkCore;
using SmartLibrary.Infrastructure.Data.Entity;

namespace SmartLibrary.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        public DbSet<TB_M_BOOK> Books { get; set; }
        public DbSet<TB_M_AUTHOR> Authors { get; set; }

    }
}
