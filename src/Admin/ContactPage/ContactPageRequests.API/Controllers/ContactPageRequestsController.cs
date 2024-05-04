using ContactPageRequests.Application.UseCases.Commands;
using ContactPageRequests.Application.UseCases.Queries;
using ContactPageRequests.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactPageRequests.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactPageRequestsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContactPageRequestsController(IMediator mediator)
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
