using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
