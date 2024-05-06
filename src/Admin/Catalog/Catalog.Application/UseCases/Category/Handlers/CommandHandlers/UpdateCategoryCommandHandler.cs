using Catalog.Application.Abstractions;
using Catalog.Application.UseCases.Category.Commands;
using Catalog.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Application.UseCases.Category.Handlers.CommandHandlers
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, ResponseModel>
    {
        private readonly ICatalogDbContext _context;

        public UpdateCategoryCommandHandler(ICatalogDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(x => x.Id == request.CategoryId);

            if (category != null)
            {
                category.CategoryName = request.CategoryName;

                _context.Categories.Update(category);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    Message = "Succesfully Updated!",
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
