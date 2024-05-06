using MediatR;

namespace Portfolio.Application.UseCases.PortfolioCases.Queries
{
    public class GetAllCategoriesQuery : IRequest<List<string>>
    {
    }
}
