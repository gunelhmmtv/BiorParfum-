﻿using AutoMapper;
using BiorParfum.Application.Dtos;
using BiorParfum.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application.Features.Queries
{
    public class GetAllRolesQueryHandler : IRequestHandler<GetAllRolesQuery, IEnumerable<RoleViewDto>>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public GetAllRolesQueryHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<IEnumerable<RoleViewDto>> Handle(GetAllRolesQuery request, CancellationToken cancellationToken)
        {
            var roles = await _uow.RoleRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<RoleViewDto>>(roles);
        }
    }
}
