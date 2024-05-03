using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Portfolio.Application
{
    public static class ProductApplicationDependencyInjection
    {
        public static IServiceCollection AddPortfolioApplicationDependencyInjection(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
