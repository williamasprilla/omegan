using Omegan.Domain.Common;
using Omegan.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Omegan.Domain
{
    public class Company : BaseDomainModel
    {
        public string NameCompany { get; set; } = string.Empty;

        public string NIT { get; set; } = string.Empty;

        public string UserId { get; set; } = string.Empty;

        [NotMapped]
        public  ApplicationUser? User { get; set; }

        public virtual ICollection<Archive>? Archives { get; set; }
    }
}
