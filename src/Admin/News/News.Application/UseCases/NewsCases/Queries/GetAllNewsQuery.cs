using MediatR;
using News.Domain.Entities;

namespace News.Application.UseCases.NewsCases.Queries
{
    public class GetAllNewsQuery : IRequest<List<NewsModel>>
    {

    }
}
