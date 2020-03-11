using SmartLibrary.Web.Models.Entity;
using SmartLibrary.WebAPI.Models.Schema;
using System;
using System.Collections.Generic;

namespace SmartLibrary.Web.IntegrationTest
{
    public static class SeedData
    {
        public static void PopulateTestData(AppDbContext dbContext)
        {
            var books = new List<Book>
            {
                new Book { Title = "Laskar Pelangi", Publisher = "Bentang Pustaka", Authors = new List<Author>{ new Author { Name="Andrea Hirata" } }, PublishedDate = DateTime.Now },
                new Book { Title = "Kesadaran Nasional Jilid 1", Publisher = "LKiS", Authors = new List<Author>{ new Author { Name="Slamet Muljana" } }, PublishedDate = DateTime.Now },
                new Book { Title = "Kesadaran Nasional Jilid 1", Publisher = "LKiS", Authors = new List<Author>{ new Author { Name="Slamet Muljana" } }, PublishedDate = DateTime.Now },
                new Book { Title = "Sejarah Pendidikan Nasional", Publisher = "Ar-Ruzz Media", Authors = new List<Author>{ new Author { Name="Muhammad Rifa'i" } }, PublishedDate = DateTime.Now },
                new Book { Title = "Pendidikan Kewarganegaraan", Publisher = "Bentang Pustaka", Authors = new List<Author>{ new Author { Name="S. Soesilo" } }, PublishedDate = DateTime.Now },
                new Book { Title = "Sejarah Indonesia", Publisher = "LKiS", Authors = new List<Author>{ new Author { Name="Soetopo" }, new Author { Name="Soedarno" } }, PublishedDate = DateTime.Now },
                new Book { Title = "Pemrograman ASP.NET", Publisher = "Adeer", Authors = new List<Author>{ new Author { Name="Hakoru" } }, PublishedDate = DateTime.Now },
                new Book { Title = "Continous Integration and Delivery", Publisher = "Bentang Pustaka", Authors = new List<Author>{ new Author { Name="Teguh Urip" } }, PublishedDate = DateTime.Now },
                new Book { Title = "Serverless Architecture", Publisher = "Eureka", Authors = new List<Author>{ new Author { Name="Abbas Histanto" } }, PublishedDate = DateTime.Now },
                new Book { Title = "Clean Code: A Handbook of Agile Software Craftmanship", Publisher = "Prentice Hall", Authors = new List<Author>{ new Author { Name="Robert C. Martin" } }, PublishedDate = DateTime.Now },
            };

            dbContext.Books.AddRange(books);
            dbContext.SaveChanges();
        }
    }
}
 