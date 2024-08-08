using AutoMapper;
using BiorParfum.Application.Extentions;
using BiorParfum.Application.Interfaces;
using BiorParfum.Domain.Entities.Products;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application.Features.Commands
{
    public class AddCategoryCommandHandler : IRequestHandler<AddCategoryCommand>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        private readonly AbstractValidator<AddCategoryCommand> _validationRules;

        public AddCategoryCommandHandler(IUnitOfWork uow, IMapper mapper, AbstractValidator<AddCategoryCommand> validationRules)
        {
            _uow = uow;
            _mapper = mapper;
            _validationRules = validationRules;
        }
        public async Task Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            await _validationRules.ThrowIfValidationFailAsync(request);
            var addressEntity = _mapper.Map<Category>(request);
            await _uow.CategoryRepository.AddAsync(addressEntity);
            await _uow.Commit();
        }
    }
}
