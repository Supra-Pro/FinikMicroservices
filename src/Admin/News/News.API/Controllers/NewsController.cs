using MediatR;
using Microsoft.AspNetCore.Mvc;
using News.Application.UseCases.NewsCases.Commands;
using News.Application.UseCases.NewsCases.Queries;
using News.Domain.Entities;

namespace News.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly IMediator mediator;

        public NewsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> CreateNews(CreateNewsCommand command)
        {
            var result = await mediator.Send(command);

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<List<NewsModel>>> GetAllNews()
        {
            var result = await mediator.Send(new GetAllNewsQuery());

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<List<NewsModel>>> GetByCategoryNews(GetByCategoryNewsCommand command)
        {
            var result = await mediator.Send(command);

            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateNews(UpdateNewsCommand command)
        {
            var result = await mediator.Send(command);

            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteNews(DeleteNewsCommand command)
        {
            var result = await mediator.Send(command);

            return Ok(result);
        }
    }
}
