using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace News.Application
{
    public static class NewsApplicationDependencyInjection
    {
        public static IServiceCollection AddNewsApplicationDependencyInjection(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
