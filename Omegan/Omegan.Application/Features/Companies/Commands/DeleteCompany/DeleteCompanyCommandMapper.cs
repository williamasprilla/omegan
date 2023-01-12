using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Companies.Commands.DeleteCompany
{
    public class DeleteCompanyCommandMapper : IRequest<string>
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
    }
}
