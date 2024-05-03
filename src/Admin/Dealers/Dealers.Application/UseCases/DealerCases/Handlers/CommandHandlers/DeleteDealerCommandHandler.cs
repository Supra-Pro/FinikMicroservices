using Dealers.Application.Abstractions;
using Dealers.Application.UseCases.DealerCases.Commands;
using Dealers.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Dealers.Application.UseCases.DealerCases.Handlers.CommandHandlers
{
    public class DeleteDealerCommandHandler : IRequestHandler<DeleteDealerCommand, ResponseModel>
    {
        private readonly IDealerDbContext _context;

        public DeleteDealerCommandHandler(IDealerDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(DeleteDealerCommand request, CancellationToken cancellationToken)
        {
            var Dealers = await _context.Dealers.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (Dealers != null)
            {
                _context.Dealers.Remove(Dealers);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    message = "Succesfully Deleted!",
                    StatusCode = 201
                };

            }

            return new ResponseModel
            {
                message = "The News is not found!",
                StatusCode = 400
            };
        }
    }
}
