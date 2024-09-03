using AutoMapper;
using BiorParfum.Application.Extentions;
using BiorParfum.Application.Interfaces;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application.Features.Commands
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        private readonly AbstractValidator<DeleteCategoryCommand> _validationRules;

        public DeleteCategoryCommandHandler(IUnitOfWork uow, IMapper mapper, AbstractValidator<DeleteCategoryCommand> validationRules)
        {
            _uow = uow;
            _mapper = mapper;
            _validationRules = validationRules;
        }

        public async Task Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            await _validationRules.ThrowIfValidationFailAsync(request);
            var categoriesEntity = await _uow.CategoryRepository.GetByIdAsync(request.Id);
            if (categoriesEntity == null)
            {
                throw new KeyNotFoundException("Category not found");
            }
             _uow.CategoryRepository.Remove(categoriesEntity);
            await _uow.Commit();

        }
    }
}
