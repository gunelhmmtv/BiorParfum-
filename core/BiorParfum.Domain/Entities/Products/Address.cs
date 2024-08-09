using BiorParfum.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Domain.Entities.Products
{
    public class Address : BaseEntity
    {
        public string CityName { get; set; }
        public string Street { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<Customer> Customer { get; set; }
    }
}
