﻿using BiorParfum.Application.Mappers;
using BiorParfum.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application.Dtos
{
    public class CategoryViewDto : IMapTo<Category>
    {
        public string Value { get; set; }
    }
}
