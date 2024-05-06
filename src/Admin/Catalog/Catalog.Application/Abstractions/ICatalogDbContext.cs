using Catalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Application.Abstractions
{
    public interface ICatalogDbContext
    {
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CatalogModel> Catalogs { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
