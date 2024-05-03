using MediatR;
using News.Domain.Entities;

namespace News.Application.UseCases.NewsCases.Queries
{
    public class GetByCategoryOfficeQuery : IRequest<IQueryable<NewsModel>>
    {
        public string CategoryName { get; set; }
    }
}
