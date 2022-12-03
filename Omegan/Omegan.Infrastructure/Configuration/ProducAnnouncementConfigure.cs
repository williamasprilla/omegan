using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Omegan.Domain;

namespace Omegan.Infrastructure.Configuration
{


    public class ProducAnnouncementConfigure : IEntityTypeConfiguration<ProductAnnouncement>
    {
        public void Configure(EntityTypeBuilder<ProductAnnouncement> builder)
        {
            builder.HasKey(pa => new {pa.ProductId , pa.AnnouncementId});
        }
    }
}
