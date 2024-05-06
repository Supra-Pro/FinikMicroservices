using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AboutPageRequests.Application
{
    public static class AboutPageRequestsApplication
    {
        public static IServiceCollection AddAboutPageRequestsApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
