using Omegan.Domain.Common;

namespace Omegan.Domain
{
    public class ProductAnnouncement
    {
        public int ProductId { get; set; }

        public Product? Product { get; set; }

        public int AnnouncementId { get; set; }

        public Announcement? Announcement { get; set; }

        public decimal Kilogram { get; set; }

    }
}
