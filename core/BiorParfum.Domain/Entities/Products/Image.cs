using BiorParfum.Domain.Entities.Accounts;
using BiorParfum.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Domain.Entities.Products
{
    public class Image : BaseEntity
    {
        public string ImageUrl { get; set; }
        public string Description { get; set; } = string.Empty;
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
