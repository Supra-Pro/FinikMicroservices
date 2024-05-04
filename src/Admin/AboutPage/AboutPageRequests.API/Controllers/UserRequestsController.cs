using AboutPageRequests.Application.Abstractions;
using AboutPageRequests.Application.UseCases.RequestCases.Commands;
using AboutPageRequests.Application.UseCases.RequestCases.Queries;
using AboutPageRequests.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AboutPageRequests.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRequestsController : ControllerBase
    {

        private readonly IMediator _mediator;

        public UserRequestsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<RequestModel>>> GetAllRequests()
        {
            var result = await _mediator.Send(new GetAllRequestsQuery());

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> CreateUserRequest(CreateRequestCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}
