using Microsoft.EntityFrameworkCore;
using News.Application.Abstractions;
using News.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Infrastructure.Persistance
{
    public class NewsDbContext : DbContext, INewsDbContext
    {
        public NewsDbContext(DbContextOptions<NewsDbContext> options):
            base(options)
        {

        }

        public DbSet<NewsModel> News { get; set; }
    }
}
