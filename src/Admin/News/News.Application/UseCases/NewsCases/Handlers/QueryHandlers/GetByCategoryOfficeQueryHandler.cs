//using MediatR;
//using Microsoft.EntityFrameworkCore;
//using News.Application.Abstractions;
//using News.Application.UseCases.NewsCases.Queries;
//using News.Domain.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace News.Application.UseCases.NewsCases.Handlers.QueryHandlers
//{
//    public class GetByCategoryOfficeQueryHandler : IRequestHandler<GetByCategoryOfficeQuery, IQueryable<NewsModel>>
//    {
//        private readonly INewsDbContext _context;

//        public GetByCategoryOfficeQueryHandler(INewsDbContext context)
//        {
//            _context = context;
//        }

//        public async Task<IQueryable<NewsModel>> Handle(GetByCategoryOfficeQuery request, CancellationToken cancellationToken)
//        {
//            var result = await _context.News.Where(x => x.Category == "Уличное");

//            return result;
//        }
//    }
//}
