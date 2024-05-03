using MediatR;
using Microsoft.EntityFrameworkCore;
using News.Application.Abstractions;
using News.Application.UseCases.NewsCases.Commands;
using News.Domain.Entities;

namespace News.Application.UseCases.NewsCases.Handlers.CommandHandlers
{
    public class DeleteNewsCommandHandler : IRequestHandler<DeleteNewsCommand, ResponseModel>
    {
        private readonly INewsDbContext _context;

        public DeleteNewsCommandHandler(INewsDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(DeleteNewsCommand request, CancellationToken cancellationToken)
        {
            var News = await _context.News.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (News != null)
            {
                _context.News.Remove(News);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    StatusCode = 201,
                    IsSuccess = true,
                    Message = "Succesfully Deleted!"
                };

            }

            return new ResponseModel
            {
                StatusCode = 400,
                Message = "The News is not found!"
            };
        }
    }
}
