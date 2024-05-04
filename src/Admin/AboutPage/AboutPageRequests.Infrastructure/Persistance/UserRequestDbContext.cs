using AboutPageRequests.Application.Abstractions;
using AboutPageRequests.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutPageRequests.Infrastructure.Persistance
{
    public class UserRequestDbContext : DbContext, IUserRequestDbContext
    {
        public UserRequestDbContext(DbContextOptions<UserRequestDbContext> options) 
            : base(options)
        {

        }

        public DbSet<RequestModel> Users { get; set; }
    }
}
