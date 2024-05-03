using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.Application.Abstractions;
using Services.Application.UseCases.ServiceCases.Commands;
using Services.Domain.Entities;

namespace Services.Application.UseCases.ServiceCases.Handlers.CommandHandlers
{
    public class DeleteServiceCommandHandler : IRequestHandler<DeleteServiceCommand, ResponseModel>
    {
        private readonly IServiceDbContext _context;

        public DeleteServiceCommandHandler(IServiceDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(DeleteServiceCommand request, CancellationToken cancellationToken)
        {
            var Service = await _context.Services.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (Service != null)
            {
                _context.Services.Remove(Service);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    Message = "Succesfully Deleted!",
                    StatusCode = 201
                };
            }

            return new ResponseModel
            {
                Message = "Service not found!",
                StatusCode = 400
            };
        }
    }
}
