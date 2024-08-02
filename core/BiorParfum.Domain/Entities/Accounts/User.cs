using BiorParfum.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Domain.Entities.Accounts
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public ICollection<UserRole?> UserRoles { get; set; } = new HashSet<UserRole?>();
        public UserDetail? UserDetail { get; set; }
        public ICollection<Review> Review { get; set; }
        public ICollection<Image> Image { get; set; }
       
    }
}
