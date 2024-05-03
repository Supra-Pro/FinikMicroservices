using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Entities;

namespace Portfolio.Application.Abstractions
{
    public interface IPortfolioDbContext
    {
        public DbSet<PortfolioModel> Portfolios { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
