using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using SmartLibrary.WebAPI.Models.Schema;

namespace SmartLibrary
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            using var db = new AppDbContext();
            db.Database.EnsureCreated();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
    }
}
