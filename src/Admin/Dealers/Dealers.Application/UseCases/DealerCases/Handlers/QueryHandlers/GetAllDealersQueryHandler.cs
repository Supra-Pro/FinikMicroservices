using Dealers.Application.Abstractions;
using Dealers.Application.UseCases.DealerCases.Queries;
using Dealers.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Dealers.Application.UseCases.DealerCases.Handlers.QueryHandlers
{
    public class GetAllDealersQueryHandler : IRequestHandler<GetAllDealersQuery, List<DealersModel>>
    {
        private readonly IDealerDbContext _context;

        public GetAllDealersQueryHandler(IDealerDbContext context)
        {
            _context = context;
        }

        public async Task<List<DealersModel>> Handle(GetAllDealersQuery request, CancellationToken cancellationToken)
        {
            return await _context.Dealers.ToListAsync(cancellationToken);
        }
    }
}
