using Microsoft.EntityFrameworkCore;

namespace eMall.Infrastructure
{
    public class EMallDbContext : DbContext
    {
        public EMallDbContext(DbContextOptions<EMallDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}