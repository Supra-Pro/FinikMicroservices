using AboutPageRequests.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AboutPageRequests.Application.Abstractions
{
    public interface IUserRequestDbContext
    {
        DbSet<RequestModel> Users { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
