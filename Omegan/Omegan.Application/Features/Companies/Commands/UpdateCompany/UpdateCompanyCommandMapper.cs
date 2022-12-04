using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Companies.Commands.UpdateCompany
{
    public class UpdateCompanyCommandMapper : IRequest
    {
        public int Id { get; set; }
        public string NameCompany { get; set; } = string.Empty;
        public string NIT { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public int State { get; set; }
    }
}
