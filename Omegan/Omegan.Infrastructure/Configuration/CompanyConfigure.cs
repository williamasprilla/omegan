using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Omegan.Domain;
using System.Reflection.Emit;

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
                .HasOne(a => a.User)
                .WithOne(b => b.Company)
                .HasForeignKey<Company>(b => b.UserId);
        }
    }
}
