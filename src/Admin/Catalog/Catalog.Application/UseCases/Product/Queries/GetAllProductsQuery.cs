using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.UseCases.Product.Queries
{
    public class GetAllProductsQuery : IRequest<List<ProductModel>>
    {

    }
}
