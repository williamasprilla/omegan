using MediatR;
using Omegan.Application.Features.Companies.Queries.GetCompanyByUserId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Companies.Queries.GetCompanyById
{
    public class GetCompanyByIdQuery : IRequest<CompanyDTO>
    {
        public GetCompanyByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
