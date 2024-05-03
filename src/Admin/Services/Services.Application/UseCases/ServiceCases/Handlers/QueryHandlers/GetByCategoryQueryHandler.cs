using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.Application.Abstractions;
using Services.Application.UseCases.ServiceCases.Queries;
using Services.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

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
            // Retrieve services by category from the database using Entity Framework Core
            var servicesByCategory = await _context.Services
                .Where(x => x.Category == request.Category)
                .ToListAsync(cancellationToken);

            // Map the retrieved services to ServiceModel objects
            var serviceModels = servicesByCategory.Select(x => new ServiceModel
            {
                Id = x.Id,
                Category = x.Category,
                Title = x.Title,
                Description = x.Description
                // Map other properties as needed
            }).ToList();

            return serviceModels;
        }
    }
}
