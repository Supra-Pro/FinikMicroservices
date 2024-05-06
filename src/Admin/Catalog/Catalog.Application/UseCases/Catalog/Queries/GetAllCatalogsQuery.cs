using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.UseCases.Catalog.Queries
{
    public class GetAllCatalogsQuery : IRequest<List<CatalogModel>>
    {

    }
}
