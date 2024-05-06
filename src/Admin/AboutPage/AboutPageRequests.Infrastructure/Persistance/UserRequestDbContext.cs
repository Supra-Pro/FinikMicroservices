using AboutPageRequests.Application.Abstractions;
using AboutPageRequests.Domain.Entities;
using Microsoft.EntityFrameworkCore;

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
