using ContactPageRequests.Application.Abstractions;
using ContactPageRequests.Application.UseCases.Queries;
using ContactPageRequests.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactPageRequests.Application.UseCases.Handlers.QueryHandlers
{
    public class GetAllRequestsQueryHandler : IRequestHandler<GetAllRequestsQuery, List<RequestModel>>
    {
        private readonly IRequestDbContext _context;

        public GetAllRequestsQueryHandler(IRequestDbContext context)
        {
            _context = context;
        }

        public async Task<List<RequestModel>> Handle(GetAllRequestsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Requests.ToListAsync(cancellationToken);
        }
    }
}
