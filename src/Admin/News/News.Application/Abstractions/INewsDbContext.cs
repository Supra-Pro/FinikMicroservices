using Microsoft.EntityFrameworkCore;
using News.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Application.Abstractions
{
    public interface INewsDbContext
    {
        public DbSet<NewsModel> News { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
