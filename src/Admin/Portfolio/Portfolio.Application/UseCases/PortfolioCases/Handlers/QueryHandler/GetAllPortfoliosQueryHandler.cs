using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Application.Abstractions;
using Portfolio.Application.UseCases.PortfolioCases.Queries;
using Portfolio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.UseCases.PortfolioCases.Handlers.QueryHandler
{
    public class GetAllPortfoliosQueryHandler : IRequestHandler<GetAllPortfoliosQuery, List<PortfolioModel>>
    {
        private readonly IPortfolioDbContext _context;

        public GetAllPortfoliosQueryHandler(IPortfolioDbContext context)
        {
            _context = context;
        }

        public async Task<List<PortfolioModel>> Handle(GetAllPortfoliosQuery request, CancellationToken cancellationToken)
        {
            return await _context.Portfolios.ToListAsync(cancellationToken);
        }
    }
}
