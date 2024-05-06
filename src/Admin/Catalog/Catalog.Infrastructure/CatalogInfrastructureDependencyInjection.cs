using Catalog.Application.Abstractions;
using Catalog.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Infrastructure
{
    public static class CatalogInfrastructureDependencyInjection
    {
        public static IServiceCollection AddCatalogInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ICatalogDbContext, CatalogDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("CatalogConnectionString"));
            });

            return services;
        }
    }
}
