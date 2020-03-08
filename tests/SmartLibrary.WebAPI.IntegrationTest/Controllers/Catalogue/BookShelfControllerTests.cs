using Newtonsoft.Json;
using SmartLibrary.Web.IntegrationTest;
using SmartLibrary.Web.Models.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
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
            
            var books = JsonConvert.DeserializeObject<IEnumerable<Book>>(stringResponse);

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
