using BiorParfum.Application.Dtos;
using BiorParfum.Application.Features.Commands;
using BiorParfum.Application.Features.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BiorParfum.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class CategoryController : ApiControllerBase
    {
        public CategoryController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        [ActionName("categories")]
        public async Task<ActionResult<ApiResponseModel<IEnumerable<CategoryViewDto>>>> GetCategories()
        {
            var categories = await _mediator.Send(new GetAllCategoryQuery());
            return await SuccessResult("Category datas is retrieved", categories);
        }

        [HttpPost]
        [ActionName("categories")]
        [Consumes("multipart/form-data")]
        public async Task<ActionResult<ApiResponseModel<string>>> AddCategories([FromForm] AddCategoryCommand command)
        {
           
            await _mediator.Send(command);

            return await SuccessResult<string>("Category added successfully");
        }


        [HttpDelete("{id}")]
        [ActionName("vacancyDetails")]
        public async Task<ActionResult<ApiResponseModel<string>>> DeleteCategories(int id)
        {
            await _mediator.Send(new DeleteCategoryCommand { Id = id });
            return await SuccessResult<string>("Category deleted successfully");
        }


    }
}


