using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Companies.Queries.GetCountries
{
    public class GetAllCountriesQuery: IRequest<List<GetCountriesDTO>>
    {

    }
}
