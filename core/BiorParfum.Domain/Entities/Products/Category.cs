using BiorParfum.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Domain.Entities.Products
{
    public class Category : BaseEntity
    {
        public Category() 
        {
            Products = new HashSet<Product>();
        }
        public string Value { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
