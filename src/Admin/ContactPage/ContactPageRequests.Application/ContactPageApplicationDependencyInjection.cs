using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ContactPageRequests.Application
{
    public static class ContactPageApplicationDependencyInjection
    {
        public static IServiceCollection AddContactPageApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
