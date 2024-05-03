using Microsoft.EntityFrameworkCore;
using Services.Application.Abstractions;
using Services.Domain.Entities;

namespace Services.Infrastructure.Persistance
{
    public class ServiceDbContext : DbContext, IServiceDbContext
    {
        public ServiceDbContext(DbContextOptions<ServiceDbContext> options)
            : base(options)
        {

        }

        public DbSet<ServiceModel> Services { get; set; }
    }
}
