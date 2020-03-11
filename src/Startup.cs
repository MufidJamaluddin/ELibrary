using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SmartLibrary.WebAPI.Models.Schema;

namespace SmartLibrary
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEntityFrameworkSqlite();

            services.AddDbContextPool<AppDbContext>((serviceProvider, optionsBuilder) => {
                optionsBuilder.UseSqlite(Configuration["ConnectionStrings:DefaultConnection"]);
                optionsBuilder.UseInternalServiceProvider(serviceProvider);
            });

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.Use(async (context, next) =>
            {
                await next().ConfigureAwait(false);
                var path = context.Request.Path.Value;

                if (!path.StartsWith("/api") && !Path.HasExtension(path))
                {
                    context.Request.Path = "/index.html";
                    await next().ConfigureAwait(false);
                }
            });

            app.UseAuthorization();

            app.UseEndpoints(endpoints => endpoints.MapControllers());

            using var appScope = app.ApplicationServices.CreateScope();

            this.SetupDatabase(appScope);
        }

        private void SetupDatabase(IServiceScope applicationScope)
        {
            using var context = applicationScope.ServiceProvider.GetService<AppDbContext>();
            context.Database.EnsureCreated();
        }
    }
}
