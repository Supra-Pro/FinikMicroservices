using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Projects.Application
{
    public static class ProjectApplicationDependencyInjection
    {
        public static IServiceCollection AddProjectApplicationDependencyInjection(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
