using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Portfolio.Application.Abstractions;
using Portfolio.Infrastructure.Persistance;

namespace Portfolio.Infrastructure
{
    public static class PortfolioInfrastructureDependencyInjection
    {
        public static IServiceCollection AddPortfolioInfrastructureDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IPortfolioDbContext, PortfolioDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("PortfolioConnectionString"));
            });

            return services;
        }
    }
}
