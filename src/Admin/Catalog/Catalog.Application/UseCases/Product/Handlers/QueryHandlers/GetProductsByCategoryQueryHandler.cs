using Catalog.Application.Abstractions;
using Catalog.Application.UseCases.Product.Queries;
using Catalog.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.UseCases.Product.Handlers.QueryHandlers
{
    public class GetProductsByCategoryQueryHandler : IRequestHandler<GetProductsByCategoryQuery, List<ProductModel>>
    {
        private readonly ICatalogDbContext _context;

        public GetProductsByCategoryQueryHandler(ICatalogDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductModel>> Handle(GetProductsByCategoryQuery request, CancellationToken cancellationToken)
        {
            var product = await _context.Products
                .Where(x => x.CategoryId == request.CategoryId)
                .ToListAsync();

            var products = product.Select(x => new ProductModel
            {
                Id = x.Id,
                Name = x.Name,
                Model = x.Model,
                IsOnSale = x.IsOnSale,
                Price = x.Price,
                TypeMontage = x.TypeMontage,
                IP = x.IP,
                Potok = x.Potok,
                Power = x.Power,
                Temperature = x.Temperature,
                EmergencyBlock = x.EmergencyBlock,
                Management = x.Management,
                CRI = x.CRI,
                CatalogId = x.CatalogId,
                CategoryId = x.CategoryId,

            }).ToList();

            return products;
        }
    }
}
