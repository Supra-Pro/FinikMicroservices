using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Application.UseCases.PortfolioCases.Commands;
using Portfolio.Application.UseCases.PortfolioCases.Queries;
using Portfolio.Domain.Entities;

namespace Portfolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortfolioController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PortfolioController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> CreatePortfolio(CreatePortfolioCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<List<PortfolioModel>>> GetAllPortfolios()
        {
            var result = await _mediator.Send(new GetAllPortfoliosQuery());

            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> UpdatePortfolio(UpdatePortfolioCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> DeletePortfolio(DeleteportfolioCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}
