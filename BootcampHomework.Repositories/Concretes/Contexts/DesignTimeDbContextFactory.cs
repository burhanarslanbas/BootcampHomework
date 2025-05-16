using BootcampHomework.Repositories.Concretes.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace BootcampHomework.Repositories.Concretes
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BaseDbContext>
    {
        public BaseDbContext CreateDbContext(string[] args)
        {
            string basePath = Path.Combine(Directory.GetCurrentDirectory(), "../BootcampHomework.API");

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            DbContextOptionsBuilder<BaseDbContext> dbContextOptionsBuilder = new();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Connection string 'DefaultConnection' not found in appsettings.json under the path: " + basePath);
            }

            dbContextOptionsBuilder.UseSqlServer(connectionString);
            return new BaseDbContext(dbContextOptionsBuilder.Options);
        }
    }
}