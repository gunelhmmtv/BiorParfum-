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
    public class AddProductsCommand :IMapTo<Product>, IRequest
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
    }
}
