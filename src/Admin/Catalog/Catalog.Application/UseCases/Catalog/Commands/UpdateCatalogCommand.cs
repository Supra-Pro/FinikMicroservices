using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.UseCases.Catalog.Commands
{
    public class UpdateCatalogCommand : IRequest<ResponseModel>
    {
        public int CatalogId { get; set; }
        public string CatalogName { get; set; }
    }
}
