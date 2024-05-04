using ContactPageRequests.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactPageRequests.Application.Abstractions
{
    public interface IRequestDbContext
    {
        public DbSet<RequestModel> Requests { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
