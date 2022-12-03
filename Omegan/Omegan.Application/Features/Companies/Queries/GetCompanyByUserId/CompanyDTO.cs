using AutoMapper;
using Omegan.Application.DTOs;
using Omegan.Domain;

namespace Omegan.Application.Features.Companies.Queries.GetCompanyByUserId
{

    [AutoMap(typeof(Company), ReverseMap = true)]
    public class CompanyDTO
    {
        public int Id { get; set; }

        public string NameCompany { get; set; } = string.Empty;

        public string NIT { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

        public virtual ICollection<ArchiveOutputDTO>? Archives { get; set; }

        public virtual ICollection<AnnouncementOuputDTO>? Announcements { get; set; }
    }
}
