using MediatR;
using Microsoft.EntityFrameworkCore;
using News.Application.Abstractions;
using News.Application.UseCases.NewsCases.Queries;
using News.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Application.UseCases.NewsCases.Handlers.QueryHandlers
{
    public class GetAllNewsQueryHandler : IRequestHandler<GetAllNewsQuery, List<NewsModel>>
    {
        private readonly INewsDbContext _context;

        public GetAllNewsQueryHandler(INewsDbContext context)
        {
            _context = context;
        }

        public async Task<List<NewsModel>> Handle(GetAllNewsQuery request, CancellationToken cancellationToken)
        {
            return await _context.News.ToListAsync(cancellationToken);
        }
    }
}
