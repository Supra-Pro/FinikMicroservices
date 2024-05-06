using Catalog.Application.Abstractions;
using Catalog.Application.UseCases.Category.Commands;
using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.UseCases.Category.Handlers.CommandHandlers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, ResponseModel>
    {
        private readonly ICatalogDbContext _context;

        public CreateCategoryCommandHandler(ICatalogDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            if (request != null)
            {
                var category = new CategoryModel
                {
                    CategoryName = request.CategoryName,
                };

                await _context.Categories.AddAsync(category);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    Message = $"{request.CategoryName} is Created!",
                    StatusCode = 201
                };
            }

            return new ResponseModel
            {
                Message = "Category isn't Created!",
                StatusCode = 400
            };
        }
    }
}
