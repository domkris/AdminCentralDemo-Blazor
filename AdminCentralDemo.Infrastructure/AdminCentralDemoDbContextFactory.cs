using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AdminCentralDemo.Infrastructure
{
    // This is only used for migrations and dotnet ef database update
    // See https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#from-a-design-time-factory
    internal class AdminCentralDemoDbContextFactory : IDesignTimeDbContextFactory<AdminCentralDemoDbContext>
    {
        public AdminCentralDemoDbContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.migrations.json")
            .Build();

            var optionsBuilder = new DbContextOptionsBuilder<AdminCentralDemoDbContext>();

            optionsBuilder.UseSqlServer(
                 configuration.GetConnectionString("Default"),
                     builder => builder.MigrationsAssembly(typeof(AdminCentralDemoDbContext).Assembly.FullName));

            return new AdminCentralDemoDbContext(optionsBuilder.Options);
        }
    }
}
