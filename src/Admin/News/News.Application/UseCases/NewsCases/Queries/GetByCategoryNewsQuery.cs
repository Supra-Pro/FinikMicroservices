using MediatR;
using News.Domain.Entities;

namespace News.Application.UseCases.NewsCases.Queries
{
    public class GetByCategoryNewsQuery : IRequest<List<NewsModel>>
    {
        public string Category { get; set; }
    }
}
