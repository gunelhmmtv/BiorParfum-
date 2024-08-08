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
    public class AddCategoryCommand:IMapTo<Category>,IRequest
    {
        public string Value { get; set; }
    }
}
