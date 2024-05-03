using MediatR;
using News.Domain.Entities;

namespace News.Application.UseCases.NewsCases.Commands
{
    public class GetByCategoryNewsCommand : IRequest<List<NewsModel>>
    {
        public string Category { get; set; }
    }
}
