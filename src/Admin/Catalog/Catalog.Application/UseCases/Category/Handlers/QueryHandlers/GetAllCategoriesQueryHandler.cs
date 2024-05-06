using Catalog.Application.Abstractions;
using Catalog.Application.UseCases.Category.Queries;
using Catalog.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Application.UseCases.Category.Handlers.QueryHandlers
{
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, List<CategoryModel>>
    {
        private readonly ICatalogDbContext _context;

        public GetAllCategoriesQueryHandler(ICatalogDbContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryModel>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            return await _context.Categories.ToListAsync(cancellationToken);
        }
    }
}
