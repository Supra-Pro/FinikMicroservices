using Microsoft.EntityFrameworkCore;
using News.Domain.Entities;

namespace News.Application.Abstractions
{
    public interface INewsDbContext
    {
        public DbSet<NewsModel> News { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
