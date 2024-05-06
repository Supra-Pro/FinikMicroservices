using ArchitecturePageRequests.Application.Abstractions;
using ArchitecturePageRequests.Application.UseCases.Queries;
using ArchitecturePageRequests.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArchitecturePageRequests.Application.UseCases.Handlers.QueryHandlers
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
