using BiorParfum.Application.Interfaces;
using BiorParfum.Domain.Entities.Accounts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Persistance.EntityFrameworks.Repositories
{
    public class EfUserRoleRepository : IUserRoleRepository
    {
        public readonly BiorParfumContext _context;
        public EfUserRoleRepository(BiorParfumContext context)
        {
            _context = context;
        }
        public async Task AddUserRole(UserRole userRoles)
        {
            await _context.UserRoles.AddAsync(userRoles);
        }

        public Task<List<UserRole>> GetUserRoles()
        {
            throw new NotImplementedException();
        }

        public bool Remove(UserRole userRole)
        {
            throw new NotImplementedException();
        }
    }
}
