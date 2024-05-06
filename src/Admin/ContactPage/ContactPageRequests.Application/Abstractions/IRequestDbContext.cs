using ContactPageRequests.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContactPageRequests.Application.Abstractions
{
    public interface IRequestDbContext
    {
        public DbSet<RequestModel> Requests { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
