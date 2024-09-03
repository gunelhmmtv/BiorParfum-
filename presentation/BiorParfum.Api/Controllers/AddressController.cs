using BiorParfum.Application.Dtos;
using BiorParfum.Application.Features.Commands;
using BiorParfum.Application.Features.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BiorParfum.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AddressController : ApiControllerBase
    {

        public AddressController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        [ActionName("addresses")]
        public async Task<ActionResult<ApiResponseModel<IEnumerable<AddressViewDto>>>> GetAddressAsync()
        {
            var addresses = await _mediator.Send(new GetAllAddressQuery());
            return await SuccessResult("Address data is retrieved", addresses);
        }

        [HttpPost]
        [ActionName("addresses")]
        public async Task<ActionResult<ApiResponseModel<string>>> AddAddress(AddAddressCommand command)
        {
            await _mediator.Send(command);
            return await SuccessResult<string>("Address added successfully");
        }
    }
}
