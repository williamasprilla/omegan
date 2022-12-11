using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Infrastructure.Configuration
{
    public class ProducCompensationConfigure: IEntityTypeConfiguration<ProductCompensation>
    {
        public void Configure(EntityTypeBuilder<ProductCompensation> builder)
        {
            builder.HasKey(pa => new { pa.ProductId, pa.CompensationId });
        }

    }
}
