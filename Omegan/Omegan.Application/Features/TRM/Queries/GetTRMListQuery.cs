using MediatR;
using Omegan.Application.Features.Products.Queries.GetProductList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.TRM.Queries
{
    public class GetTRMListQuery: IRequest<List<TrmDTO>>
    {

    }
}
