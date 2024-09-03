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
    public class ProductController : ApiControllerBase
    {
        public ProductController(IMediator mediator) : base(mediator) 
        {
            
        }

        [HttpGet]
        [ActionName("products")]

        public async Task<ActionResult<ApiResponseModel<IEnumerable<ProductViewDto>>>> GetProductsAsync()
        {
            var products = await _mediator.Send(new GetAllProductQuery());
            return await SuccessResult("Product data is selected",products);
        }

        [HttpPost]
        [ActionName("products")]

        public async Task<ActionResult<ApiResponseModel<string>>> AddProducts(AddProductsCommand command)
        {
            await _mediator.Send(command);
            return await SuccessResult<string>("Product added succesfully");
        }

        [HttpPut]
        [ActionName("products")]
        public async Task<ActionResult<ApiResponseModel<string>>> UpdateProduct(UpdateProductCommand command)
        {
            var user = User;
            await _mediator.Send(command);
            return await SuccessResult<string>("Product updated successfully");
        }

        [HttpDelete("{id}")]
        [ActionName("products")]

        public async Task<ActionResult<ApiResponseModel<string>>> DeleteProduct(int id)
        {
            await _mediator.Send(new DeleteProductCommand { Id = id });
            return await SuccessResult<string>("Product deleted successfully");
        }



    }
}
