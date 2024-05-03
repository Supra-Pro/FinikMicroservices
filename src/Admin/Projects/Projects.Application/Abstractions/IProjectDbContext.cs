using Microsoft.EntityFrameworkCore;
using Projects.Domain.Eintities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Application.Abstractions
{
    public interface IProjectDbContext
    {
        public DbSet<ProjectsModel> Projects { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
