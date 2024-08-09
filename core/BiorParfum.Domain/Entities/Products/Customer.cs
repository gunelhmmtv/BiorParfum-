using BiorParfum.Domain.Entities.Accounts;
using BiorParfum.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Domain.Entities.Products
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Order> Order { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int? AddressId { get; set; }
        public Address Address { get; set; }
    }
}
