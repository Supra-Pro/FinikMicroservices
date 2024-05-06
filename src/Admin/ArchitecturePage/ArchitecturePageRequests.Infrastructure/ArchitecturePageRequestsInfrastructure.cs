using ArchitecturePageRequests.Application.Abstractions;
using ArchitecturePageRequests.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ArchitecturePageRequests.Infrastructure
{
    public static class ArchitecturePageRequestsInfrastructure
    {
        public static IServiceCollection AddArchitecturePageRequestsInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IRequestDbContext, RequestDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("ArchitecturePageConnectionString"));
            });

            return services;
        }
    }
}
