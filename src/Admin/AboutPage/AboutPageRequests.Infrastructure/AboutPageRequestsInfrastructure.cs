using AboutPageRequests.Application.Abstractions;
using AboutPageRequests.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutPageRequests.Infrastructure
{
    public static class AboutPageRequestsInfrastructure 
    {
        public static IServiceCollection AddAboutPageRequestsInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IUserRequestDbContext, UserRequestDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("AboutPageUserRequestsFINIKDB"));
            });

            return services;
        }
    }
}
