using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartLibrary.Web.Models.Entity;
using SmartLibrary.Web.Models.Repository;

namespace SmartLibrary.Web.Controllers.Catalogue
{
    [ApiController]
    [Route("api/catalogue/[controller]")]
    public class BookShelfController : ControllerBase
    {
        private readonly ILogger<BookShelfController> _logger;
        private readonly BookRepository _repository;

        public BookShelfController(ILogger<BookShelfController> logger)
        {
            this._logger = logger;
            this._repository = new BookRepository();
        }

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            var books = new List<Book>();

            books.AddRange(this._repository.GetBooks());

            return books;
        }
    }
}
