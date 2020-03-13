using Newtonsoft.Json;
using SmartLibrary.Infrastructure.Data.Entity;
using SmartLibrary.Web.IntegrationTest;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Xunit;

namespace SmartLibrary.WebAPI.IntegrationTest.Controllers.Catalogue
{
    public class BookShelfControllerTests : IClassFixture<IntegrationTestWebAppFactory<Startup>>
    {
        private readonly HttpClient _client;

        public BookShelfControllerTests(IntegrationTestWebAppFactory<Startup> factory)
        {
            this._client = factory.CreateClient();
        }

        [Fact]
        public async void TestResultCount()
        {
            var httpResponse = await this._client.GetAsync("/api/catalogue/bookshelf");

            httpResponse.EnsureSuccessStatusCode();

            var stringResponse = await httpResponse.Content.ReadAsStringAsync();

            var books = JsonConvert.DeserializeObject<IEnumerable<TB_M_BOOK>>(stringResponse);

            Assert.Equal(10, books.ToList().Count);
        }

        [Fact]
        public async void TestGetOneBook()
        {
            var httpResponse = await this._client.GetAsync("/api/catalogue/bookshelf/1");

            httpResponse.EnsureSuccessStatusCode();
        }
    }
}
