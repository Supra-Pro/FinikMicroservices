using Dealers.Application.UseCases.DealerCases.Commands;
using Dealers.Application.UseCases.DealerCases.Queries;
using Dealers.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Dealers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DealersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> CreateDealer(CreateDealerCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<List<DealersModel>>> GetAllDealers()
        {
            var result = await _mediator.Send(new GetAllDealersQuery());

            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateDealer(UpdateDealerCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteDealer(DeleteDealerCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}
