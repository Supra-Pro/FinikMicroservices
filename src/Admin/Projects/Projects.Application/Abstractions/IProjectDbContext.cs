using Microsoft.EntityFrameworkCore;
using Projects.Domain.Eintities;

namespace Projects.Application.Abstractions
{
    public interface IProjectDbContext
    {
        public DbSet<ProjectsModel> Projects { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
