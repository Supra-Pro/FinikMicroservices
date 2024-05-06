using MediatR;
using News.Application.Abstractions;
using News.Application.UseCases.NewsCases.Queries;

namespace News.Application.UseCases.NewsCases.Handlers.QueryHandlers
{
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, List<string>>
    {
        private readonly INewsDbContext _context;

        public GetAllCategoriesQueryHandler(INewsDbContext context)
        {
            _context = context;
        }

        public Task<List<string>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categories = _context.News
            .Select(s => s.Category)
            .Distinct()
            .ToList();

            return Task.FromResult(categories);
        }
    }
}
