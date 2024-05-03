using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Services.Application
{
    public static class ServiceApplicationDependencyInjection
    {
        public static IServiceCollection AddServiceApplicationDependencyInjection(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
