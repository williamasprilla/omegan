using Omegan.Domain.Common;

namespace Omegan.Domain
{
    public class Archive : BaseDomainModel
    {
        public string Name { get; set; } = string.Empty;

        public string Base64 { get; set; } = string.Empty;

        public string Type { get; set; } = string.Empty;

        public bool Status { get; set; } 

        public bool Active { get; set; }

        public int CompanyId { get; set; }

        public virtual Company? Company { get; set; }
    }
}
