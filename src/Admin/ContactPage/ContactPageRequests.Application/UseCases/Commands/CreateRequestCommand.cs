using ContactPageRequests.Domain.Entities;
using MediatR;

namespace ContactPageRequests.Application.UseCases.Commands
{
    public class CreateRequestCommand : IRequest<ResponseModel>
    {
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
