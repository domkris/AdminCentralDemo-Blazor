using Microsoft.EntityFrameworkCore;

namespace AdminCentralDemo.Infrastructure
{
    public class AdminCentralDemoDbContext : DbContext
    {
        public AdminCentralDemoDbContext(
            DbContextOptions<AdminCentralDemoDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
