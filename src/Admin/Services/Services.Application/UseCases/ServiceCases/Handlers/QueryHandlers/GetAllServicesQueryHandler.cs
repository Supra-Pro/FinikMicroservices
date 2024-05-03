using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.Application.Abstractions;
using Services.Application.UseCases.ServiceCases.Queries;
using Services.Domain.Entities;

namespace Services.Application.UseCases.ServiceCases.Handlers.QueryHandlers
{
    public class GetAllServicesQueryHandler : IRequestHandler<GetAllServicesQuery, List<ServiceModel>>
    {
        private readonly IServiceDbContext _context;

        public GetAllServicesQueryHandler(IServiceDbContext context)
        {
            _context = context;
        }

        public async Task<List<ServiceModel>> Handle(GetAllServicesQuery request, CancellationToken cancellationToken)
        {
            return await _context.Services.ToListAsync(cancellationToken);
        }
    }
}
