using Catalog.Application.UseCases.Category.Commands;
using Catalog.Application.UseCases.Product.Commands;
using Catalog.Application.UseCases.Product.Queries;
using Catalog.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> CreateProduct(CreateProductCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductModel>>> GetAllProducts()
        {
            var result = await _mediator.Send(new GetAllProductsQuery());

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetProductsByCategory(int categoryId)
        {
            try
            {
                var query = new GetProductsByCategoryQuery { CategoryId = categoryId };
                var products = await _mediator.Send(query);

                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"error {ex.Message}");
            }
        }

        [HttpPut]
        public async Task<ActionResult> UpdateProduct(UpdateProductCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteProduct(DeleteProductCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}
