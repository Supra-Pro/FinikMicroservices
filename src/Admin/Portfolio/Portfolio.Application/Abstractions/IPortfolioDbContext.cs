using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Abstractions
{
    public interface IPortfolioDbContext
    {
        public DbSet<PortfolioModel> Portfolios { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
