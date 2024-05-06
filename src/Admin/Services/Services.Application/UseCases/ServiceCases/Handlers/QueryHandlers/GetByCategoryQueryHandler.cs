using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.Application.Abstractions;
using Services.Application.UseCases.ServiceCases.Queries;
using Services.Domain.Entities;

namespace Services.Application.UseCases.ServiceCases.Handlers.QueryHandlers
{
    public class GetByCategoryQueryHandler : IRequestHandler<GetByCategoryQuery, List<ServiceModel>>
    {
        private readonly IServiceDbContext _context;

        public GetByCategoryQueryHandler(IServiceDbContext context)
        {
            _context = context;
        }

        public async Task<List<ServiceModel>> Handle(GetByCategoryQuery request, CancellationToken cancellationToken)
        {

            var servicesByCategory = await _context.Services
                .Where(x => x.Category == request.Category)
                .ToListAsync(cancellationToken);


            var serviceModels = servicesByCategory.Select(x => new ServiceModel
            {
                Id = x.Id,
                Category = x.Category,
                Title = x.Title,
                Description = x.Description

            }).ToList();

            return serviceModels;
        }
    }
}
