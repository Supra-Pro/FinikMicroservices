using AboutPageRequests.Application.Abstractions;
using AboutPageRequests.Application.UseCases.RequestCases.Queries;
using AboutPageRequests.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutPageRequests.Application.UseCases.RequestCases.Handlers.QueryHandlers
{
    public class GetAllRequestsQueryHandler : IRequestHandler<GetAllRequestsQuery, List<RequestModel>>
    {
        private readonly IUserRequestDbContext _context;

        public GetAllRequestsQueryHandler(IUserRequestDbContext context)
        {
            _context = context;
        }

        public async Task<List<RequestModel>> Handle(GetAllRequestsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Users.ToListAsync(cancellationToken);
        }
    }
}
