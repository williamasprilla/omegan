using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Omegan.Domain;

namespace Omegan.Infrastructure.Configuration
{

    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(


                new Product
                {
                    Id = 1,
                    TariffItem = "001",
                    Description = "Carne en canal"
                },
                new Product
                  {
                   Id = 2,
                   TariffItem = "002",
                   Description = "Carne industrial"
                },

                new Product
                {
                    Id = 3,
                    TariffItem = "003",
                    Description = "Carne empacada al vacio extra"
                },

               new Product
               {
                   Id = 4,
                   TariffItem = "004",
                   Description = "Carne empacada al vacio primera"
               },

                new Product
                {
                    Id = 5,
                    TariffItem = "005",
                    Description = "Carne empacada al vacio segunda"
                },

                new Product
                {
                    Id = 6,
                    TariffItem = "006",
                    Description = "Leche en polvo"
                },

               new Product
               {
                   Id = 7,
                   TariffItem = "007",
                   Description = "Leche UHT"
               },

             new Product
             {
                 Id = 8,
                 TariffItem = "008",
                 Description = "Quesos maduros"
             }
            );
        }
    }
}
