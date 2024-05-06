using MediatR;
using Services.Application.Abstractions;
using Services.Application.UseCases.ServiceCases.Queries;

namespace Services.Application.UseCases.ServiceCases.Handlers.QueryHandlers
{
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, List<string>>
    {
        private readonly IServiceDbContext _context;

        public GetAllCategoriesQueryHandler(IServiceDbContext context)
        {
            _context = context;
        }

        public Task<List<string>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            // Retrieve all unique categories from the database
            var categories = _context.Services
                .Select(s => s.Category)
                .Distinct()
                .ToList();

            return Task.FromResult(categories);
        }
    }
}
