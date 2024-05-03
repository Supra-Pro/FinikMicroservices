using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.Application.Abstractions;
using Services.Infrastructure.Persistance;

namespace Services.Infrastructure
{
    public static class ServiceInfrastructureDependencyInjection
    {
        public static IServiceCollection AddServiceInfrastructureDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IServiceDbContext, ServiceDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("ServiceConnectionString"));
            });

            return services;
        }
    }
}
