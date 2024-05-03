using MediatR;
using Microsoft.EntityFrameworkCore;
using Projects.Application.Abstractions;
using Projects.Application.UseCases.ProjectCases.Queries;
using Projects.Domain.Eintities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Application.UseCases.ProjectCases.Handlers.QueryHandlers
{
    public class GetProjectsByCategoryQueryHandler : IRequestHandler<GetProjectsByCategoryQuery, List<ProjectsModel>>
    {
        private readonly IProjectDbContext _context;

        public GetProjectsByCategoryQueryHandler(IProjectDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProjectsModel>> Handle(GetProjectsByCategoryQuery request, CancellationToken cancellationToken)
        {
            var project = await _context.Projects
                .Where(x => x.Category ==  request.Category)
                .ToListAsync();

            var projects = project.Select(x => new ProjectsModel{

                Id = x.Id,
                Category = x.Category,
                Title = x.Title,
                Body = x.Body,
            
            }).ToList();

            return projects;
        }
    }
}
