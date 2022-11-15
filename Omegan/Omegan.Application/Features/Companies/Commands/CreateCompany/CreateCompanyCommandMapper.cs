using MediatR;
using Omegan.Application.DTOs;
using Omegan.Domain;
using Omegan.Domain.Models;

namespace Omegan.Application.Features.Companies.Commands.CreateCompany
{

    public class CreateCompanyCommandMapper : IRequest<int>
    {
        public string NameCompany { get; set; } = string.Empty;

        public string NIT { get; set; } = string.Empty;

        public string UserId { get; set; } = string.Empty;

        public List<ArchiveDTO> Archives { get; set; } = new List<ArchiveDTO>();

    }
}
