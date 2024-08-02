using BiorParfum.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Domain.Entities.Products
{
    public class Country: BaseEntity
    {
        public string Name { get; set; }
        public Address Address { get; set; }
    }
}
