using AutoMapper;
using MediatR;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Features.Products.Queries.GetProductList;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.TRM.Queries
{
    public class GetTRMListQueryHandler: IRequestHandler<GetTRMListQuery, List<TrmDTO>>
    {
        private readonly IGenericRepository<Trm, int> _trmRepository;
        private readonly IMapper _mapper;

        public GetTRMListQueryHandler(IGenericRepository<Trm, int> trmRepository, IMapper mapper)
        {
            _trmRepository = trmRepository;
            _mapper = mapper;
        }

        public async Task<List<TrmDTO>> Handle(GetTRMListQuery request, CancellationToken cancellationToken)
        {
            var trmList = await _trmRepository.ListAllAsync();
            return _mapper.Map<List<TrmDTO>>(trmList);
        }
    }
}
