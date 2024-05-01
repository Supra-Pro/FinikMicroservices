using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using News.Application.Abstractions;
using News.Infrastructure.Persistance;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Infrastructure
{
    public static class NewsInfrastructureDependencyInjection
    {
        public static IServiceCollection AddNewsInfrastructureDependencyInjection(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<INewsDbContext, NewsDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("NewsConnectionString"));
            });

            return services;
        }
    }
}
