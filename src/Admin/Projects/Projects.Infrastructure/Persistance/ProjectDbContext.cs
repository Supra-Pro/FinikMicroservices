using Microsoft.EntityFrameworkCore;
using Projects.Application.Abstractions;
using Projects.Domain.Eintities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
