using Catalog.Application.UseCases.Catalog.Commands;
using Catalog.Application.UseCases.Catalog.Queries;
using Catalog.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CatalogController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<ActionResult> CreateCatalog(CreateCatalogCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }


        [HttpGet]
        public async Task<ActionResult<List<CatalogModel>>> GetAllCatalogs()
        {
            var result = await _mediator.Send(new GetAllCatalogsQuery());

            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateCatalog(UpdateCatalogCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteCatalog(DeleteCatalogCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}
