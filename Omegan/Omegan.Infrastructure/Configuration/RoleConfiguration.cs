using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Omegan.Infrastructure.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(


                new IdentityRole
                {
                    Id = "b947fb18-600f-4057-b05e-d306abffedb6",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },

                new IdentityRole
                {
                    Id = "aebfc368-0c43-4b94-8cce-26c277ec2e33",
                    Name = "Empresa Exportadora",
                    NormalizedName = "EMPRESA EXPORTADORA"
                },

                new IdentityRole
                {
                    Id = "93296f46-5fd1-4b67-bb8d-9a9008adc8e6",
                    Name = "Representante Legal",
                    NormalizedName = "Representante Legal"
                },

                new IdentityRole
                {
                    Id = "a0b13f5f-1fdc-4937-99ac-91c4a5c8e1bc",
                    Name = "Comite Directivo",
                    NormalizedName = "COMITE DIRECTIVO"
                },

                new IdentityRole
                {
                    Id = "b344f3b4-1df4-449e-8553-9dd7640820a2",
                    Name = "Secretaria Tecnica",
                    NormalizedName = "SECRETARIA TECNICA"
                },

                new IdentityRole
                {
                    Id = "10096115-e173-4e82-903f-8b4c8f8e2ceb",
                    Name = "Coordinacion Operativa",
                    NormalizedName = "COORDINACION OPERATIVA"
                },

                new IdentityRole
                {
                    Id = "9cd3b078-3254-4c05-b404-e527ec616c89",
                    Name = "Profesional I",
                    NormalizedName = "PROFESIONAL I"
                },

                new IdentityRole
                {
                    Id = "3a52dfb8-8595-487e-bd07-2e876c8291a5",
                    Name = "Auditoria Interna",
                    NormalizedName = "AUDITORIA INTERNA"
                }
                ,
                new IdentityRole
                {
                   Id = "3a03991c-5128-4011-85bd-5886dd9f0906",
                   Name = "Asistente  Compensaciones",
                   NormalizedName = "ASISTENTE DE COMPENSACIONES"
                },
                new IdentityRole
                {
                   Id = "a02a081e-e197-40a3-85a4-3f4cfc853961",
                   Name = "Contabilidad",
                   NormalizedName = "CONTABILIDAD"
                }
            );
        }
    }
}
