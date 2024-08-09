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
    public class EfRoleRepository : IRoleRepository
    {
        private readonly BiorParfumContext _context;
        public EfRoleRepository(BiorParfumContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Role role)
        {
            await _context.Roles.AddAsync(role);
        }

        public bool DeleteAsync(Role role)
        {
            var removed = _context.Set<Role>().Remove(role);
            return removed.State == EntityState.Deleted;
        }

        public Task<IEnumerable<Role>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Role> GetByIdAsync(int id)
        {
            return await _context.Set<Role>().FindAsync(id);
        }

        public async Task<List<Role?>> GetRoles()
        {
            return await _context.Set<Role>().ToListAsync();
        }

        public bool UpdateAsync(Role role)
        {
            _context.Entry(role).State = EntityState.Modified;
            return true;
        }
    }
}
