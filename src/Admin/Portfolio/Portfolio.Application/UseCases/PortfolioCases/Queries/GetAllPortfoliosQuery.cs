using MediatR;
using Portfolio.Domain.Entities;

namespace Portfolio.Application.UseCases.PortfolioCases.Queries
{
    public class GetAllPortfoliosQuery : IRequest<List<PortfolioModel>>
    {

    }
}
