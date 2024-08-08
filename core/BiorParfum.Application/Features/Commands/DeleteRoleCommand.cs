﻿using BiorParfum.Application.Mappers;
using BiorParfum.Domain.Entities.Accounts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application.Features.Commands
{
    public class DeleteRoleCommand : IMapTo<Role>,IRequest
    {
        public int Id { get; set; }
    }
}
