using AboutPageRequests.Application.Abstractions;
using AboutPageRequests.Application.UseCases.RequestCases.Commands;
using AboutPageRequests.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutPageRequests.Application.UseCases.RequestCases.Handlers.CommandHandlers
{
    public class CreateRequestCommandHandler : IRequestHandler<CreateRequestCommand, ResponseModel>
    {
        private readonly IUserRequestDbContext _context;

        public CreateRequestCommandHandler(IUserRequestDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(CreateRequestCommand request, CancellationToken cancellationToken)
        {
            if (request != null)
            {
                var NewRequest = new RequestModel
                {
                    Name = request.Name,
                    CityOfImplementation = request.CityOfImplementation,
                    PhoneNumber = request.PhoneNumber,
                    PlannedSales = request.PlannedSales,
                };

                await _context.Users.AddAsync(NewRequest);
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
