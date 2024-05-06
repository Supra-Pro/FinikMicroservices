using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.UseCases.Catalog.Commands
{
    public class CreateCatalogCommand : IRequest<ResponseModel>
    {
        public string CatalogName { get; set; }
    }
}
