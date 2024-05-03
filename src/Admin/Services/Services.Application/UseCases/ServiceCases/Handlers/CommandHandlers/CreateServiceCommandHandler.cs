using MediatR;
using Services.Application.Abstractions;
using Services.Application.UseCases.ServiceCases.Commands;
using Services.Domain.Entities;

namespace Services.Application.UseCases.ServiceCases.Handlers.CommandHandlers
{
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand, ResponseModel>
    {
        private readonly IServiceDbContext _context;

        public CreateServiceCommandHandler(IServiceDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            if (request != null)
            {
                var Service = new ServiceModel
                {
                    Category = request.Category,
                    Title = request.Title,
                    Description = request.Description
                };

                await _context.Services.AddAsync(Service);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    Message = "Succesfully Created!",
                    StatusCode = 201
                };
            }
            return new ResponseModel
            {
                Message = "Error",
                StatusCode = 400
            };
        }
    }
}
