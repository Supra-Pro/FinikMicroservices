using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Projects.Application.Abstractions;
using Projects.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Infrastructure
{
    public static class ProjectInfrastructureDependencyInjection
    {
        public static IServiceCollection AddProjectInfrastructureDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IProjectDbContext, ProjectDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("ProjectConnectionString"));
            });

            return services;
        }
    }
}
