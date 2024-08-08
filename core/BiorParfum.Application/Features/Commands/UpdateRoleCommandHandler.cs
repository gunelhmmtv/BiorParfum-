using AutoMapper;
using BiorParfum.Application.Interfaces;
using BiorParfum.Domain.Entities.Accounts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application.Features.Commands
{
    public class UpdateRoleCommandHandler : IRequestHandler<UpdateRoleCommand>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateRoleCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
        {

            var existingRole = await _unitOfWork.RoleRepository.GetByIdAsync(request.Id);

            if (existingRole != null)
            {
                _mapper.Map(request, existingRole);
                _unitOfWork.RoleRepository.UpdateAsync(existingRole);
            }
            else
            {
                var newRole = _mapper.Map<Role>(request);
                await _unitOfWork.RoleRepository.AddAsync(newRole);
            }

            await _unitOfWork.Commit();
        }
    }
}
