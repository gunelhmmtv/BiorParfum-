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
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        private readonly AbstractValidator<DeleteProductCommand> _validationRules;
        public DeleteProductCommandHandler(IUnitOfWork uow, IMapper mapper, AbstractValidator<DeleteProductCommand> validationRules)
        {
            _uow = uow;
            _mapper = mapper;
            _validationRules = validationRules;
        }
        public async Task Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            await _validationRules.ThrowIfValidationFailAsync(request);
            var productEntity = await _uow.ProductRepository.GetByIdAsync(request.Id);
            if (productEntity == null)
            {
                throw new KeyNotFoundException("Product not found");
            }
             _uow.ProductRepository.Remove(productEntity);
            await _uow.Commit();
        }
    }
}
