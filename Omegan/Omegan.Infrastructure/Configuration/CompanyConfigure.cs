using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Omegan.Domain;

namespace Omegan.Infrastructure.Configuration
{

    public class CompanyConfigure : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.Property(p => p.NameCompany).IsRequired().HasMaxLength(100);
            builder.Property(p => p.NIT).IsRequired().HasMaxLength(10);


            builder
              .HasMany(m => m.Archives)
              .WithOne(m => m.Company)
              .HasForeignKey(m => m.CompanyId)
              .IsRequired()
              .OnDelete(DeleteBehavior.Restrict);

            builder
              .HasMany(m => m.Announcements)
              .WithOne(m => m.Company)
              .HasForeignKey(m => m.CompanyId);

            builder
                .HasOne(a => a.User)
                .WithOne(b => b.Company)
                .HasForeignKey<Company>(b => b.UserId);
        }
    }
}
