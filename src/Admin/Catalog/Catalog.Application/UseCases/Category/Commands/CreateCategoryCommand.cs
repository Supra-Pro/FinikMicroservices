using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.UseCases.Category.Commands
{
    public class CreateCategoryCommand : IRequest<ResponseModel>
    {
        public string CategoryName { get; set; }
    }
}
