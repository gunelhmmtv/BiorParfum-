using BiorParfum.Application.Mappers;
using BiorParfum.Domain.Entities.Products;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application.Features.Commands
{
    public class AddAddressCommand:IMapTo<Address>,IRequest
    {
        public string CityName { get; set; }
        public string Street { get; set; }
        public int CountryId { get; set; }
    }
}
