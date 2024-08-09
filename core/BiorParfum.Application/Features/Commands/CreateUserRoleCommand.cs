using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application.Features.Commands
{
    public class CreateUserRoleCommand : IRequest
    {
        public int UserId { get; set; }
        public ICollection<int> RoleIds { get; set; }
    }
}
