using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using PayMon.Data; // Updated to match the new namespace

namespace PayMon.Data // Changed from PayMon.DbContext to PayMon.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<PayMonDbContext>
    {
        public PayMonDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<PayMonDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);

            return new PayMonDbContext(optionsBuilder.Options);
        }
    }
}
