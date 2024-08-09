using BiorParfum.Persistance.EntityFrameworks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace BiorParfum.Api.Data
{
    public class SampleContextFactory : IDesignTimeDbContextFactory<BiorParfumContext>
    {
        public BiorParfumContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<BiorParfumContext>();
            var connectionString = configuration.GetConnectionString("local");
            builder.UseSqlServer(connectionString, b => b.MigrationsAssembly("BarrenSellTicket.WebApi"));

            return new BiorParfumContext(builder.Options);
        }
    }
}
