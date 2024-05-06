using ContactPageRequests.Application.Abstractions;
using ContactPageRequests.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ContactPageRequests.Infrastructure
{
    public static class ContactPageInfrastructure
    {
        public static IServiceCollection AddContactPageRequestsInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IRequestDbContext, RequestDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("ContactPageConnectionString"));
            });

            return services;
        }
    }
}
