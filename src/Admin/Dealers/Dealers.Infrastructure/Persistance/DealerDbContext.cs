using Dealers.Application.Abstractions;
using Dealers.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dealers.Infrastructure.Persistance
{
    public class DealerDbContext : DbContext, IDealerDbContext
    {
        public DealerDbContext(DbContextOptions<DealerDbContext> options)
            : base(options)
        {

        }

        public DbSet<DealersModel> Dealers { get; set; }
    }
}
