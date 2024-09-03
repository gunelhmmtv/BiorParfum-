using BiorParfum.Application.Mappers;
using BiorParfum.Domain.Entities.Products;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application.Dtos
{
    public class CategoryViewDto : IMapTo<Category>
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}
