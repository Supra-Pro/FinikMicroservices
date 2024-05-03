using Dealers.Application.Abstractions;
using Dealers.Application.UseCases.DealerCases.Commands;
using Dealers.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Dealers.Application.UseCases.DealerCases.Handlers.CommandHandlers
{
    public class UpdateDealerCommandHandler : IRequestHandler<UpdateDealerCommand, ResponseModel>
    {
        private readonly IDealerDbContext _context;

        public UpdateDealerCommandHandler(IDealerDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(UpdateDealerCommand request, CancellationToken cancellationToken)
        {
            var dealer = await _context.Dealers.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (dealer != null)
            {
                dealer.Title = request.Title;
                dealer.Description = request.Description;

                _context.Dealers.Update(dealer);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    message = "Succesfully Updated",
                    StatusCode = 201
                };
            }

            return new ResponseModel
            {
                message = "Dealer Not Found",
                StatusCode = 400
            };
        }
    }
}
