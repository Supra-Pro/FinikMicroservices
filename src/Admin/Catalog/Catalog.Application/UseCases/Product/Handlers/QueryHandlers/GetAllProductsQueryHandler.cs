using Catalog.Application.Abstractions;
using Catalog.Application.UseCases.Product.Queries;
using Catalog.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Application.UseCases.Product.Handlers.QueryHandlers
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<ProductModel>>
    {
        private readonly ICatalogDbContext _cotnext;

        public GetAllProductsQueryHandler(ICatalogDbContext cotnext)
        {
            _cotnext = cotnext;
        }

        public async Task<List<ProductModel>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await _cotnext.Products.ToListAsync(cancellationToken);
        }
    }
}
