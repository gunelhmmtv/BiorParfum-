using BiorParfum.Domain.Entities.Accounts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application.Interfaces
{
    public interface IRoleRepository:IRequest<Role>
    {
        Task AddAsync(Role role);
        Task<List<Role?>> GetRoles();
        bool UpdateAsync(Role role);
        bool DeleteAsync(Role role);
        Task<IEnumerable<Role>> GetAllAsync();
        Task<Role> GetByIdAsync(int ıd);
    }
}
