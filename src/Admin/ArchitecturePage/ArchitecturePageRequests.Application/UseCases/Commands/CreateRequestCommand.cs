using ArchitecturePageRequests.Domain.Entities;
using MediatR;

namespace ArchitecturePageRequests.Application.UseCases.Commands
{
    public class CreateRequestCommand : IRequest<ResponseModel>
    {
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
