using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.Application.Abstractions;
using Services.Application.UseCases.ServiceCases.Commands;
using Services.Domain.Entities;

namespace Services.Application.UseCases.ServiceCases.Handlers.CommandHandlers
{
    public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommand, ResponseModel>
    {
        private readonly IServiceDbContext _context;

        public UpdateServiceCommandHandler(IServiceDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
        {
            var Service = await _context.Services.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (Service != null)
            {
                Service.Category = request.Category;
                Service.Title = request.Title;
                Service.Description = request.Description;

                _context.Services.Update(Service);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    Message = "Succesfully Updated!",
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
