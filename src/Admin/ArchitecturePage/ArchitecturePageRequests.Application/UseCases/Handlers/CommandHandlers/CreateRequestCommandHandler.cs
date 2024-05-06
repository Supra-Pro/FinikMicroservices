using ArchitecturePageRequests.Application.Abstractions;
using ArchitecturePageRequests.Application.UseCases.Commands;
using ArchitecturePageRequests.Domain.Entities;
using MediatR;

namespace ArchitecturePageRequests.Application.UseCases.Handlers.CommandHandlers
{

    public class CreateRequestCommandHandler : IRequestHandler<CreateRequestCommand, ResponseModel>
    {
        private readonly IRequestDbContext _context;

        public CreateRequestCommandHandler(IRequestDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(CreateRequestCommand request, CancellationToken cancellationToken)
        {
            if (request != null)
            {
                var user = new RequestModel
                {
                    Name = request.Name,
                    Email = request.Email,
                    PhoneNumber = request.PhoneNumber,
                    Message = request.Message,
                };

                await _context.Requests.AddAsync(user);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    Message = "Succesfully Added",
                    StatusCode = 201
                };
            }

            return new ResponseModel
            {
                Message = "User Error",
                StatusCode = 400
            };
        }
    }
}
