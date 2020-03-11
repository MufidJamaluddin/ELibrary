using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SmartLibrary.WebAPI.Models.Schema;

namespace SmartLibrary.Web.IntegrationTest
{
    public class IntegrationTestWebAppFactory<TStartup> : WebApplicationFactory<Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                services.AddDbContextPool<AppDbContext>(options =>
                {
                    options.UseInMemoryDatabase("InMemoryAppDb");
                    options.UseInternalServiceProvider(
                        new ServiceCollection()
                            .AddEntityFrameworkInMemoryDatabase()
                            .BuildServiceProvider()
                    );
                });

                var serviceProvider = services.BuildServiceProvider();

                using var scope = serviceProvider.CreateScope();
                var scopedServices = scope.ServiceProvider;
                var applicationDatabase = scopedServices.GetRequiredService<AppDbContext>();

                var logger = scopedServices.GetRequiredService<ILogger<IntegrationTestWebAppFactory<TStartup>>>();

                // Belum Ketemu Destroy DB Test Sebelumnya dari Memory, DB Context Singleton Pool
                applicationDatabase.Database.EnsureDeleted();

                applicationDatabase.Database.EnsureCreated();

                try
                {
                    SeedData.PopulateTestData(applicationDatabase);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "An error occured while populating test data. Info: {ex.Message}");
                }
            });
        }
    }
}
