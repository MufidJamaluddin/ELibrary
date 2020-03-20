using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartLibrary.Domain.BorrowBook.Entity;
using SmartLibrary.Infrastructure.Data;
using SmartLibrary.Infrastructure.Data.Repository;
using System.Collections.Generic;

namespace SmartLibrary.Web.Controllers.Catalogue
{
    [ApiController]
    [Route("api/catalogue/[controller]")]
    public class BookShelfController : ControllerBase
    {
        private readonly ILogger<BookShelfController> _logger;
        private readonly BookRepository _repository;

        public BookShelfController(ILogger<BookShelfController> logger, AppDbContext dbContext)
        {
            this._logger = logger;
            this._repository = new BookRepository(dbContext);
        }

        [HttpGet]
        public List<Book> GetAllBooks()
        {
            var books = this._repository.GetBooks();

            return books;
        }

        [HttpGet("{id}")]
        public Book GetBookById(int id)
        {
            var book = this._repository.GetBookById(id);

            return book;
        }
    }
}
