using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using News.Application.Abstractions;
using News.Infrastructure.Persistance;

namespace News.Infrastructure
{
    public static class NewsInfrastructureDependencyInjection
    {
        public static IServiceCollection AddNewsInfrastructureDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<INewsDbContext, NewsDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("NewsConnectionString"));
            });

            return services;
        }
    }
}
