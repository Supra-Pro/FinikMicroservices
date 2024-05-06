using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.UseCases.Catalog.Commands
{
    public class DeleteCatalogCommand : IRequest<ResponseModel>
    {
        public int CatalogId { get; set; }
    }
}
