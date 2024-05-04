using ArchitecturePageRequests.Application.Abstractions;
using ArchitecturePageRequests.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturePageRequests.Infrastructure.Persistance
{
    public class RequestDbContext : DbContext, IRequestDbContext
    {
        public RequestDbContext(DbContextOptions<RequestDbContext> options) : base(
            options)
        {

        }

        public DbSet<RequestModel> Requests { get; set; }
    }
}
