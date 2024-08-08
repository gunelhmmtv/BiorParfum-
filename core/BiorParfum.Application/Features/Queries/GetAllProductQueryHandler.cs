using AutoMapper;
using BiorParfum.Application.Dtos;
using BiorParfum.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application.Features.Queries
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, IEnumerable<ProductViewDto>>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public GetAllProductQueryHandler(IUnitOfWork uow,IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
            
        }
        public async Task<IEnumerable<ProductViewDto>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var products = await _uow.ProductRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductViewDto>>(products);
        }
    }
}
