using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Application.Abstractions;
using Portfolio.Application.UseCases.PortfolioCases.Queries;
using Portfolio.Domain.Entities;

namespace Portfolio.Application.UseCases.PortfolioCases.Handlers.QueryHandler
{
    public class GetPortfoliosByCategoryQueryHandler : IRequestHandler<GetPortfoliosByCategoryQuery, List<PortfolioModel>>
    {
        private readonly IPortfolioDbContext _context;

        public GetPortfoliosByCategoryQueryHandler(IPortfolioDbContext context)
        {
            _context = context;
        }

        public async Task<List<PortfolioModel>> Handle(GetPortfoliosByCategoryQuery request, CancellationToken cancellationToken)
        {
            var portfolio = await _context.Portfolios
                .Where(x => x.Category == request.Category)
                .ToListAsync();

            var portfolios = portfolio.Select(x => new PortfolioModel
            {
                Id = x.Id,
                Category = x.Category,
                Title = x.Title,
                Body = x.Body,

            }).ToList();

            return portfolios;
        }
    }
}
