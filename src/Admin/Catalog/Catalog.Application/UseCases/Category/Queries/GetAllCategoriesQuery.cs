using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.UseCases.Category.Queries
{
    public class GetAllCategoriesQuery : IRequest<List<CategoryModel>>
    {

    }
}
