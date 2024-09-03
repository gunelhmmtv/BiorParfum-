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
    public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQuery, IEnumerable<CategoryViewDto>>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public GetAllCategoryQueryHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async  Task<IEnumerable<CategoryViewDto>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
            var categories = await _uow.CategoryRepository.GetAllAsync();

            if (categories is null)
            {
                throw new NullReferenceException("Category is null");

            }

            var categoriesDto= new List<CategoryViewDto>();

            foreach (var category in categories)
            {
                var categoryDto = new CategoryViewDto
                {
                    Value = category.Value,
                };
                categoriesDto.Add(categoryDto);
            }
            return categoriesDto;
        }
    }
}
