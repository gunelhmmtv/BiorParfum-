using AutoMapper;
using BiorParfum.Application.Extentions;
using BiorParfum.Application.Interfaces;
using BiorParfum.Domain.Entities.Products;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application.Features.Commands
{
    public class AddProductsCommandHandler : IRequestHandler<AddProductsCommand>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        private readonly AbstractValidator<AddProductsCommand> validationRules;
        public AddProductsCommandHandler(IUnitOfWork uow, IMapper mapper, AbstractValidator<AddProductsCommand> validationRules)
        {
            _uow = uow;
            _mapper = mapper;
            this.validationRules = validationRules;
        }
        public async Task Handle(AddProductsCommand request, CancellationToken cancellationToken)
        {
            await validationRules.ThrowIfValidationFailAsync(request);
            var productEntity = _mapper.Map<Product>(request);
            await _uow.ProductRepository.AddAsync(productEntity);
            await _uow.Commit();
        }
    }
}
