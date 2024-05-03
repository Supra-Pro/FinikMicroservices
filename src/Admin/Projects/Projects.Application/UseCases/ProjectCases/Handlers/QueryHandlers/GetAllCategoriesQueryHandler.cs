using MediatR;
using Projects.Application.Abstractions;
using Projects.Application.UseCases.ProjectCases.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Application.UseCases.ProjectCases.Handlers.QueryHandlers
{
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, List<string>>
    {
        private readonly IProjectDbContext _context;

        public GetAllCategoriesQueryHandler(IProjectDbContext context)
        {
            _context = context;
        }

        public Task<List<string>> Handle(GetAllCategoriesQuery request,  CancellationToken cancellationToken)
        {
            var categories = _context.Projects
                .Select(x => x.Category)
                .Distinct()
                .ToList();

            return Task.FromResult(categories);
        }
    }
}
