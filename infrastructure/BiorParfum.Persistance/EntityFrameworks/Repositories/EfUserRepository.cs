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
    public class EfUserRepository : IUserRepository
    {
        private readonly BiorParfumContext _dbContext;

        public EfUserRepository(BiorParfumContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddUser(User user)
        {
            await _dbContext.Set<User>().AddAsync(user);
        }

        public async Task<User?> GetUserWithDetail(string email)
        {
            return await _dbContext.Set<User>()
                .Include(x => x.UserDetail)
                .FirstOrDefaultAsync(x => x.Email == email);
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
