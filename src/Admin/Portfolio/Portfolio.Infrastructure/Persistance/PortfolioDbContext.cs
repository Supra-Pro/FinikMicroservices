using Microsoft.EntityFrameworkCore;
using Portfolio.Application.Abstractions;
using Portfolio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Infrastructure.Persistance
{
    public class PortfolioDbContext : DbContext, IPortfolioDbContext
    {
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(
            options)
        {
            
        }

        public DbSet<PortfolioModel> Portfolios { get; set; }
    }
}
