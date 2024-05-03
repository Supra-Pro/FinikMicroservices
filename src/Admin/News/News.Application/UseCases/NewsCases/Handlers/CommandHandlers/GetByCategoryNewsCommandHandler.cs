using MediatR;
using Microsoft.EntityFrameworkCore;
using News.Application.Abstractions;
using News.Application.UseCases.NewsCases.Commands;
using News.Domain.Entities;

namespace News.Application.UseCases.NewsCases.Handlers.CommandHandlers
{
    public class GetByCategoryNewsCommandHandler : IRequestHandler<GetByCategoryNewsCommand, List<NewsModel>>
    {
        private readonly INewsDbContext _context;

        public GetByCategoryNewsCommandHandler(INewsDbContext context)
        {
            _context = context;
        }

        public async Task<List<NewsModel>> Handle(GetByCategoryNewsCommand request, CancellationToken cancellationToken)
        {
            var News = await _context.News.Where(x => x.Category == request.Category).ToListAsync(cancellationToken);

            return News.Select(n => new NewsModel
            {

                Id = n.Id,
                Category = n.Category,
                PostedDate = n.PostedDate,
                NewsTitle = n.NewsTitle,
                NewsBody = n.NewsBody,

            }).ToList();
        }
    }
}
