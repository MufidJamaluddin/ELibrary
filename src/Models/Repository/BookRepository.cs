using SmartLibrary.Web.Models.Entity;
using SmartLibrary.WebAPI.Models.Schema;
using System.Collections.Generic;
using System.Linq;

namespace SmartLibrary.Web.Models.Repository
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            using var dbContext = new AppDbContext();

            return dbContext.Books.Where(x => x.Title != null).ToList();
        }
    }
}
