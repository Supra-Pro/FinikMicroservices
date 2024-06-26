﻿using ContactPageRequests.Application.Abstractions;
using ContactPageRequests.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContactPageRequests.Infrastructure.Persistance
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
