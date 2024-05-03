using Dealers.Application.Abstractions;
using Dealers.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dealers.Infrastructure
{
    public static class DealerInfrastructureDependencyInjection
    {
        public static IServiceCollection AddDealerInfrastructureDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IDealerDbContext, DealerDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DealerConnectionString"));
            });

            return services;
        }
    }
}
