using Microsoft.EntityFrameworkCore;
using Omegan.Domain;
using Omegan.Domain.Common;
using System.Reflection;

namespace Omegan.Infrastructure.Persistence
{

    public class OmeganDbContext : DbContext
    {
        public OmeganDbContext(DbContextOptions<OmeganDbContext> options) : base(options)
        {
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainModel>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        entry.Entity.CreatedBy = "system";
                        break;

                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        entry.Entity.LastModifiedBy = "system";
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }


        public DbSet<Company> Companies  => Set<Company>();
        public DbSet<Archive> Archives  => Set<Archive>();


    }
}

