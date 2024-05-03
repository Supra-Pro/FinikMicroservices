using MediatR;
using Portfolio.Application.Abstractions;
using Portfolio.Application.UseCases.PortfolioCases.Commands;
using Portfolio.Domain.Entities;

namespace Portfolio.Application.UseCases.PortfolioCases.Handlers.CommandHandler
{
    public class CreatePortfolioCommandHandler : IRequestHandler<CreatePortfolioCommand, ResponseModel>
    {
        private readonly IPortfolioDbContext _context;

        public CreatePortfolioCommandHandler(IPortfolioDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(CreatePortfolioCommand request, CancellationToken cancellationToken)
        {
            if (request != null)
            {
                var Portfolio = new PortfolioModel
                {
                    Category = request.Category,
                    Title = request.Title,
                    Body = request.Body,
                };

                await _context.Portfolios.AddAsync(Portfolio);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    Message = "Succesfully Created!",
                    StatusCode = 201,
                    IsSuccess = true
                };
            }

            return new ResponseModel
            {
                Message = "The portfolio is not created!",
                StatusCode = 400
            };
        }
    }
}
