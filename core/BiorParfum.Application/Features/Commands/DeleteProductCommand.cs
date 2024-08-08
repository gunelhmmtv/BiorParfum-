﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application.Features.Commands
{
    public class DeleteProductCommand: IRequest
    {
        public int Id { get; set; }
    }
}
