using MediatR;
using Microsoft.AspNetCore.Mvc;
using Services.Application.UseCases.ServiceCases.Commands;
using Services.Application.UseCases.ServiceCases.Queries;

namespace Services.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ServicesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> CreateService(CreateServiceCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult> GetAllServices()
        {
            var result = await _mediator.Send(new GetAllServicesQuery());
            
            return Ok(result);      
        }

        [HttpPut]
        public async Task<ActionResult> UpdateService(UpdateServiceCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteService(DeleteServiceCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}
