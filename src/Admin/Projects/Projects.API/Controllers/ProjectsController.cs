using MediatR;
using Microsoft.AspNetCore.Mvc;
using Projects.Application.UseCases.ProjectCases.Commands;
using Projects.Application.UseCases.ProjectCases.Queries;
using Projects.Domain.Eintities;

namespace Projects.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProjectsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> CreateProject(CreateProjectCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<List<ProjectsModel>>> GetAllProjects()
        {
            var result = await _mediator.Send(new GetAllProjectsQuery());

            return result;
        }

        [HttpGet]
        public async Task<IActionResult> GetProjectsByCategory([FromBody] string category)
        {
            try
            {
                var query = new GetProjectsByCategoryQuery { Category = category };
                var projects = await _mediator.Send(query);

                return Ok(projects);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"error {ex.Message}");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var query = new GetAllCategoriesQuery();
            var categories = await _mediator.Send(query);
            return Ok(categories);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateProjects(UpdateProjectCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteProject(DeleteProjectCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}
