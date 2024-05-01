using MediatR;
using Microsoft.EntityFrameworkCore;
using News.Application.Abstractions;
using News.Application.UseCases.NewsCases.Commands;
using News.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Application.UseCases.NewsCases.Handlers.CommandHandlers
{
    public class UpdateNewsCommandHandler : IRequestHandler<UpdateNewsCommand, ResponseModel>
    {
        private readonly INewsDbContext _context;

        public UpdateNewsCommandHandler(INewsDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(UpdateNewsCommand request, CancellationToken cancellationToken)
        {
            var News = await _context.News.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (News != null)
            {
                News.Category = request.Category;
                News.PostedDate = request.PostedDate;
                News.NewsTitle = request.NewsTitle;
                News.NewsBody = request.NewsBody;

                _context.News.Update(News);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    StatusCode = 201,
                    IsSuccess = true,
                    Message = $"News with given id:{News.Id} is Succesfully Updated!"
                };
            }

            return new ResponseModel
            {
                StatusCode = 400,
                Message = "News Not found!"
            };
        }
    }
}
