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
    public class CreateUserRoleCommandHandler : IRequestHandler<CreateUserRoleCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateUserRoleCommandHandler( IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task Handle(CreateUserRoleCommand request, CancellationToken cancellationToken)
        {
            var existingUserRole = (await _unitOfWork.UserRoleRepository.GetUserRoles())
                 .Where(e => e.UserId == request.UserId)
                 .ToList();

            foreach (var item in existingUserRole)
            {
                _unitOfWork.UserRoleRepository.Remove(item);
            }

            foreach (var item in request.RoleIds)
            {
                await _unitOfWork.UserRoleRepository.AddUserRole(new UserRole
                {
                    RoleId = item,
                    UserId = request.UserId
                });
            }

            await _unitOfWork.Commit();
        }
    }
}
