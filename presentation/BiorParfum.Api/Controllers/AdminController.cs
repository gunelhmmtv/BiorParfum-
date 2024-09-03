using BiorParfum.Application.Dtos;
using BiorParfum.Application.Features.Commands;
using BiorParfum.Application.Features.Queries;
using BiorParfum.Domain.Entities.Accounts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BiorParfum.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdminController : ApiControllerBase
    {
        public AdminController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        [ActionName("roles")]
        public async Task<ActionResult<ApiResponseModel<IEnumerable<RoleViewDto>>>> GetAllRolesAsync()
        {
            var roles = await _mediator.Send(new GetAllRolesQuery());
            return await SuccessResult("Roles data is retrieved", roles);
        }

        [HttpPost]
        [ActionName("roles")]
        public async Task<ActionResult<ApiResponseModel<string>>> AddRole(AddRoleCommand command)
        {
            await _mediator.Send(command);
            return await SuccessResult<string>("Role added successfully");
        }

        [HttpPut]
        [ActionName("roles")]
        public async Task<ActionResult<ApiResponseModel<string>>> UpdateRole(UpdateRoleCommand command)
        {
            await _mediator.Send(command);
            return await SuccessResult<string>("Role updated successfully");
        }

        [HttpDelete]
        [ActionName("roles")]
        public async Task<ActionResult<ApiResponseModel<string>>> DeleteRole(DeleteRoleCommand command)
        {
            await _mediator.Send(command);
            return await SuccessResult<string>("Role deleted successfully");
        }
    }
}
