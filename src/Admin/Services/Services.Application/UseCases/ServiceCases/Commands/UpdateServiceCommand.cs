using MediatR;
using Services.Domain.Entities;

namespace Services.Application.UseCases.ServiceCases.Commands
{
    public class UpdateServiceCommand : IRequest<ResponseModel>
    {
        public Guid Id { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
