using MediatR;
using News.Application.Abstractions;
using News.Application.UseCases.NewsCases.Commands;
using News.Domain.Entities;

namespace News.Application.UseCases.NewsCases.Handlers.CommandHandlers
{
    public class CreateNewsCommandHandler : IRequestHandler<CreateNewsCommand, ResponseModel>
    {
        private readonly INewsDbContext _context;

        public CreateNewsCommandHandler(INewsDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(CreateNewsCommand request, CancellationToken cancellationToken)
        {
            if (request != null)
            {
                var News = new NewsModel
                {
                    Category = request.Category,
                    PostedDate = request.PostedDate,
                    NewsTitle = request.NewsTitle,
                    NewsBody = request.NewsBody,
                };

                await _context.News.AddAsync(News, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    Message = "News is succesfully created!",
                    IsSuccess = true,
                    StatusCode = 201
                };
            }

            return new ResponseModel
            {
                Message = "News isn't Created",
                StatusCode = 400
            };
        }
    }
}
