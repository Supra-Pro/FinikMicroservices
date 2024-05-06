using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.UseCases.Category.Commands
{
    public class DeleteCategoryCommand : IRequest<ResponseModel>
    {
        public int CategoryId { get; set; }
    }
}
