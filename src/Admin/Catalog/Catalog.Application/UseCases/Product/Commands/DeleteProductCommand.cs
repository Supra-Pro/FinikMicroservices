using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.UseCases.Product.Commands
{
    public class DeleteProductCommand : IRequest<ResponseModel>
    {
        public Guid ProductId { get; set; }
    }
}
