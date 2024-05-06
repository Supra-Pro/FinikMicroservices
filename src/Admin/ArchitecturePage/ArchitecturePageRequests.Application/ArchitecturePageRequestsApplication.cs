using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ArchitecturePageRequests.Application
{
    public static class ArchitecturePageRequestsApplication
    {
        public static IServiceCollection AddArchitecturePageApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
