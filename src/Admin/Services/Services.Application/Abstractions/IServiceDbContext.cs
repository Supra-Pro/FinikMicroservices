using Microsoft.EntityFrameworkCore;
using Services.Domain.Entities;

namespace Services.Application.Abstractions
{
    public interface IServiceDbContext
    {
        public DbSet<ServiceModel> Services { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
