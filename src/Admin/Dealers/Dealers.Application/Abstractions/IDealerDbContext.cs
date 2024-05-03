using Dealers.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dealers.Application.Abstractions
{
    public interface IDealerDbContext
    {
        public DbSet<DealersModel> Dealers { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
