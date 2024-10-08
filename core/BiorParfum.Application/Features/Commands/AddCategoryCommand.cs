﻿using BiorParfum.Application.Mappers;
using BiorParfum.Domain.Entities.Products;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
