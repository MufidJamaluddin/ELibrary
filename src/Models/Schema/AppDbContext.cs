using Microsoft.EntityFrameworkCore;
using SmartLibrary.Web.Models.Entity;

namespace SmartLibrary.WebAPI.Models.Schema
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

    }
}
