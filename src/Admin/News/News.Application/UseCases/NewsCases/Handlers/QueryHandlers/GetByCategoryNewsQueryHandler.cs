using MediatR;
using Microsoft.EntityFrameworkCore;
using News.Application.Abstractions;
using News.Application.UseCases.NewsCases.Queries;
using News.Domain.Entities;

namespace News.Application.UseCases.NewsCases.Handlers.QueryHandlers
{
    public class GetByCategoryNewsQueryHandler : IRequestHandler<GetByCategoryNewsQuery, List<NewsModel>>
    {
        private readonly INewsDbContext _context;

        public GetByCategoryNewsQueryHandler(INewsDbContext context)
        {
            _context = context;
        }

        public async Task<List<NewsModel>> Handle(GetByCategoryNewsQuery request, CancellationToken cancellationToken)
        {
            var News = await _context.News
                .Where(x => x.Category == request.Category)
                .ToListAsync(cancellationToken);

            var NewsModels = News.Select(x => new NewsModel
            {
                Id = x.Id,
                Category = x.Category,
                PostedDate = x.PostedDate,
                NewsTitle = x.NewsTitle,
                NewsBody = x.NewsBody,

            }).ToList();

            return NewsModels;
        }
    }
}
