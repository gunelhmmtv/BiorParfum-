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
    public class AddAddressCommandHandler : IRequestHandler<AddAddressCommand>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        private readonly AbstractValidator<AddAddressCommand> _validationRules;
        public AddAddressCommandHandler(IUnitOfWork uow, IMapper mapper, AbstractValidator<AddAddressCommand> validationRules)
        {
            _uow = uow;
            _mapper = mapper;
            _validationRules = validationRules;

        }
        public async Task Handle(AddAddressCommand request, CancellationToken cancellationToken)
        {
            await _validationRules.ThrowIfValidationFailAsync(request);
            var addressEntity = _mapper.Map<Address>(request);
            await _uow.AddressRepository.AddAsync(addressEntity);
            await _uow.Commit();
        }
    }
}
