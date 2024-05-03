using Microsoft.EntityFrameworkCore;
using News.Application.Abstractions;
using News.Domain.Entities;

namespace News.Infrastructure.Persistance
{
    public class NewsDbContext : DbContext, INewsDbContext
    {
        public NewsDbContext(DbContextOptions<NewsDbContext> options) :
            base(options)
        {

        }

        public DbSet<NewsModel> News { get; set; }
    }
}
