using MediatR;
using Portfolio.Application.Abstractions;
using Portfolio.Application.UseCases.PortfolioCases.Queries;

namespace Portfolio.Application.UseCases.PortfolioCases.Handlers.QueryHandler
{
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, List<string>>
    {
        private readonly IPortfolioDbContext _context;

        public GetAllCategoriesQueryHandler(IPortfolioDbContext context)
        {
            _context = context;
        }

        public Task<List<string>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categories = _context.Portfolios
            .Select(x => x.Category)
            .Distinct()
            .ToList();

            return Task.FromResult(categories);
        }
    }
}
