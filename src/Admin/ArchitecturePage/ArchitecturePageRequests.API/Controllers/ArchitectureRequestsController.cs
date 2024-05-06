using ArchitecturePageRequests.Application.UseCases.Commands;
using ArchitecturePageRequests.Application.UseCases.Queries;
using ArchitecturePageRequests.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ArchitecturePageRequests.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArchitectureRequestsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ArchitectureRequestsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> CreateUserRequest(CreateRequestCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<List<RequestModel>>> GetAllRequests()
        {
            var result = await _mediator.Send(new GetAllRequestsQuery());

            return Ok(result);
        }
    }
}
