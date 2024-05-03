using Dealers.Application.Abstractions;
using Dealers.Application.UseCases.DealerCases.Commands;
using Dealers.Domain.Entities;
using MediatR;

namespace Dealers.Application.UseCases.DealerCases.Handlers.CommandHandlers
{
    public class CreateDealerCommandHandler : IRequestHandler<CreateDealerCommand, ResponseModel>
    {
        private readonly IDealerDbContext _context;

        public CreateDealerCommandHandler(IDealerDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(CreateDealerCommand request, CancellationToken cancellationToken)
        {
            if (request != null)
            {
                var dealer = new DealersModel
                {
                    Title = request.Title,
                    Description = request.Description,
                    AddedAt = DateTime.UtcNow,
                };

                await _context.Dealers.AddAsync(dealer, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    message = "New dealer is Succesfully Added!",
                    StatusCode = 201
                };
            }
            return new ResponseModel
            {
                message = "Dealer is not Added!",
                StatusCode = 400
            };
        }
    }
}
