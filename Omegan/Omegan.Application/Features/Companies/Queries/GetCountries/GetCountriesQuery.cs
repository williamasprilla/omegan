using MediatR;
using Omegan.Application.Features.Companies.Queries.GetCompanyByUserId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Companies.Queries.GetCountries
{
    public class GetCountriesQuery : IRequest<GetCountriesDTO>
    {
        public GetCountriesQuery(int countryId)
        {
            CountryId = countryId;
        }
        public int CountryId { get; set; }

    }
}
