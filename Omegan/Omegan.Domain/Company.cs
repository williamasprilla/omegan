using Omegan.Domain.Common;
using Omegan.Domain.Models;

namespace Omegan.Domain
{
    public class Company : AuditableEntity , IEntity<int>
    {
        public string NameCompany { get; set; } = string.Empty;

        public string NIT { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string UserId { get; set; } = string.Empty;

        public virtual ApplicationUser? User { get; set; }

        public virtual ICollection<Archive>? Archives { get; set; }

        public virtual ICollection<Announcement>? Announcements { get; set; }
    }
}
