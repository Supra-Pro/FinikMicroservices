﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Application.UseCases.PortfolioCases.Commands;
using Portfolio.Application.UseCases.PortfolioCases.Queries;
using Portfolio.Domain.Entities;

namespace Portfolio.API.Controllers
{
    [Route("api/[controller]/[action]")]
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

        [HttpGet]
        public async Task<IActionResult> GetPortfoliosByCategory([FromBody] string category)
        {
            try
            {
                var query = new GetPortfoliosByCategoryQuery { Category = category };
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
