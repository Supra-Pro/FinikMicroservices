using MediatR;

namespace Services.Application.UseCases.ServiceCases.Queries
{
    public class GetAllCategoriesQuery : IRequest<List<string>>
    {

    }
}
