using BiorParfum.Domain.Entities.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application.Interfaces
{
    public interface IUserRepository
    {
        Task AddUser(User user);

        void UpdateUser(User user);

        Task<User?> GetUserWithDetail(string email);


    }
}
