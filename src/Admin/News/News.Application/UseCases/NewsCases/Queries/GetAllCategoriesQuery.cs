using MediatR;

namespace News.Application.UseCases.NewsCases.Queries
{
    public class GetAllCategoriesQuery : IRequest<List<string>>
    {

    }
}
