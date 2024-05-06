using Catalog.Application.Abstractions;
using Catalog.Application.UseCases.Catalog.Queries;
using Catalog.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Application.UseCases.Catalog.Handlers.QueryHandlers
{
    public class GetAllCatalogsQueryHandler : IRequestHandler<GetAllCatalogsQuery, List<CatalogModel>>
    {
        private readonly ICatalogDbContext _context;

        public GetAllCatalogsQueryHandler(ICatalogDbContext context)
        {
            _context = context;
        }

        public async Task<List<CatalogModel>> Handle(GetAllCatalogsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Catalogs.ToListAsync(cancellationToken);
        }
    }
}
