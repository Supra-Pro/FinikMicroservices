using Catalog.Application.Abstractions;
using Catalog.Application.UseCases.Category.Commands;
using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.UseCases.Category.Handlers.CommandHandlers
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, ResponseModel>
    {
        private readonly ICatalogDbContext _context;

        public DeleteCategoryCommandHandler(ICatalogDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = _context.Categories.FirstOrDefault(x => x.Id == request.CategoryId);
            
            if (category != null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync(cancellationToken);


                return new ResponseModel
                {
                    Message = "Succesfully Deleted!",
                    StatusCode = 201
                };

            }

            return new ResponseModel
            {
                Message = "Category not found!",
                StatusCode = 400
            };
        }
    }
}
