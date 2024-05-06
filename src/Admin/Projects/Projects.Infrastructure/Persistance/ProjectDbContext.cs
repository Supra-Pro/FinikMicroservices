using Microsoft.EntityFrameworkCore;
using Projects.Application.Abstractions;
using Projects.Domain.Eintities;

namespace Projects.Infrastructure.Persistance
{
    public class ProjectDbContext : DbContext, IProjectDbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options)
            : base(options)
        {

        }
        public DbSet<ProjectsModel> Projects { get; set; }
    }
}
