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
    public class GetAllProjectsQueryHandler : IRequestHandler<GetAllProjectsQuery, List<ProjectsModel>>
    {
        private readonly IProjectDbContext _context;

        public GetAllProjectsQueryHandler(IProjectDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProjectsModel>> Handle(GetAllProjectsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Projects.ToListAsync(cancellationToken);
        }
    }
}
