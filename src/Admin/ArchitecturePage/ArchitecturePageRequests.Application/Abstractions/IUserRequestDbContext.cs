using ArchitecturePageRequests.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ArchitecturePageRequests.Application.Abstractions
{
    public interface IRequestDbContext
    {
        public DbSet<RequestModel> Requests { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
