using MediatR;
using Services.Domain.Entities;

namespace Services.Application.UseCases.ServiceCases.Commands
{
    public class DeleteServiceCommand : IRequest<ResponseModel>
    {
        public Guid Id { get; set; }
    }
}
