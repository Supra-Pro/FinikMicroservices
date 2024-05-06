using Catalog.Application.Abstractions;
using Catalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Infrastructure.Persistance
{
    public class CatalogDbContext : DbContext, ICatalogDbContext
    {
        public CatalogDbContext(DbContextOptions<CatalogDbContext> options)
            : base(options)
        {

        }

        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CatalogModel> Catalogs { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
    }
}
