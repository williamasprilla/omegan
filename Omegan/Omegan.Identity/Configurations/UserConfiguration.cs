using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Omegan.Domain.Models;

namespace Omegan.Identity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                    new ApplicationUser
                    {
                        Id = "7fa985ac-095c-469b-b98d-8e09a947d66a",
                        Email = "admin@locahost.com",
                        NormalizedEmail = "admin@locahost.com",
                        Nombre = "Omegan",
                        Apellidos = "Admin",
                        UserName = "OmeganAdmin",
                        NormalizedUserName = "omeganadmin",
                        PhoneNumber = "3175226569",
                        PasswordHash = hasher.HashPassword(null, "Colombia25+"),
                        EmailConfirmed = true,
                    }
                );
        }
    }
}
