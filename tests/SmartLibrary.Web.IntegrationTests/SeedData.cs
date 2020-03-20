using SmartLibrary.Infrastructure.Data;
using SmartLibrary.Infrastructure.Data.Entity;
using System;
using System.Collections.Generic;

namespace SmartLibrary.Web.IntegrationTest
{
    public static class SeedData
    {
        public static void PopulateTestData(AppDbContext dbContext)
        {
            var books = new List<TB_M_BOOK>
            {
                new TB_M_BOOK { Title = "Laskar Pelangi", Publisher = "Bentang Pustaka", Authors = new List<TB_M_AUTHOR>{ new TB_M_AUTHOR { Name="Andrea Hirata" } }, PublishedDate = DateTime.Now },
                new TB_M_BOOK { Title = "Kesadaran Nasional Jilid 1", Publisher = "LKiS", Authors = new List<TB_M_AUTHOR>{ new TB_M_AUTHOR { Name="Slamet Muljana" } }, PublishedDate = DateTime.Now },
                new TB_M_BOOK { Title = "Kesadaran Nasional Jilid 1", Publisher = "LKiS", Authors = new List<TB_M_AUTHOR>{ new TB_M_AUTHOR { Name="Slamet Muljana" } }, PublishedDate = DateTime.Now },
                new TB_M_BOOK { Title = "Sejarah Pendidikan Nasional", Publisher = "Ar-Ruzz Media", Authors = new List<TB_M_AUTHOR>{ new TB_M_AUTHOR { Name="Muhammad Rifa'i" } }, PublishedDate = DateTime.Now },
                new TB_M_BOOK { Title = "Pendidikan Kewarganegaraan", Publisher = "Bentang Pustaka", Authors = new List<TB_M_AUTHOR>{ new TB_M_AUTHOR { Name="S. Soesilo" } }, PublishedDate = DateTime.Now },
                new TB_M_BOOK { Title = "Sejarah Indonesia", Publisher = "LKiS", Authors = new List<TB_M_AUTHOR>{ new TB_M_AUTHOR { Name="Soetopo" }, new TB_M_AUTHOR { Name="Soedarno" } }, PublishedDate = DateTime.Now },
                new TB_M_BOOK { Title = "Pemrograman ASP.NET", Publisher = "Adeer", Authors = new List<TB_M_AUTHOR>{ new TB_M_AUTHOR { Name="Hakoru" } }, PublishedDate = DateTime.Now },
                new TB_M_BOOK { Title = "Continous Integration and Delivery", Publisher = "Bentang Pustaka", Authors = new List<TB_M_AUTHOR>{ new TB_M_AUTHOR { Name="Teguh Urip" } }, PublishedDate = DateTime.Now },
                new TB_M_BOOK { Title = "Serverless Architecture", Publisher = "Eureka", Authors = new List<TB_M_AUTHOR>{ new TB_M_AUTHOR { Name="Abbas Histanto" } }, PublishedDate = DateTime.Now },
                new TB_M_BOOK { Title = "Clean Code: A Handbook of Agile Software Craftmanship", Publisher = "Prentice Hall", Authors = new List<TB_M_AUTHOR>{ new TB_M_AUTHOR { Name="Robert C. Martin" } }, PublishedDate = DateTime.Now },
            };

            dbContext.TB_M_BOOK.AddRange(books);
            dbContext.SaveChanges();
        }
    }
}
