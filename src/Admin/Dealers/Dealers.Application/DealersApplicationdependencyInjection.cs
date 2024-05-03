using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Dealers.Application
{
    public static class DealersApplicationdependencyInjection
    {
        public static IServiceCollection AddDealersApplicationDependencyInjection(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
