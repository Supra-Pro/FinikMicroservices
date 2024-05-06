using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.UseCases.Category.Commands
{
    public class UpdateCategoryCommand : IRequest<ResponseModel>
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
