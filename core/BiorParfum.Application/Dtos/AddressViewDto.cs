using BiorParfum.Application.Mappers;
using BiorParfum.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application.Dtos
{
    public class AddressViewDto : IMapTo<Address>
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
    }
}
