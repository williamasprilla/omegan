using Omegan.Domain.Common;

namespace Omegan.Domain
{
    public class Product : AuditableEntity, IEntity<int>
    {
        public string TariffItem { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public virtual ICollection<ProductAnnouncement>? ProductAnnouncements { get; set; }

    }
}
