using MediatR;
using Portfolio.Domain.Entities;

namespace Portfolio.Application.UseCases.PortfolioCases.Queries
{
    public class GetPortfoliosByCategoryQuery : IRequest<List<PortfolioModel>>
    {
        public string Category { get; set; }
    }
}
