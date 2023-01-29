using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Omegan.Application.Interfaces.Common;
using Omegan.Domain;
using Omegan.Domain.Common;
using Omegan.Domain.Models;
using System.Reflection;

namespace Omegan.Infrastructure.Persistence
{

    public class OmeganDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;


        public OmeganDbContext(DbContextOptions<OmeganDbContext> options, ICurrentUserService currentUserService,
            IDateTime dateTime) : base(options)
        {
            _currentUserService = currentUserService;
            _dateTime = dateTime;
        }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = "System";//_currentUserService.UserId;
                        entry.Entity.CreatedDate = _dateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = "System";//_currentUserService.UserId;
                        entry.Entity.LastModifiedDate = _dateTime.Now;
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
        public DbSet<Product> Products => Set<Product>();
        public DbSet<ProductAnnouncement> ProductAnnouncements => Set<ProductAnnouncement>();
        public DbSet<Country> Countrys => Set<Country>();
        public DbSet<Trm> Trm => Set<Trm>();
        public DbSet<Compensation> Compensation => Set<Compensation>();
        public DbSet<ProductCompensation> ProductCompensations => Set<ProductCompensation>();

    }
}

