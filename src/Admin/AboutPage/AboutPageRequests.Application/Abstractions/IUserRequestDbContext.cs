using AboutPageRequests.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutPageRequests.Application.Abstractions
{
    public interface IUserRequestDbContext
    {
         DbSet<RequestModel> Users { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
