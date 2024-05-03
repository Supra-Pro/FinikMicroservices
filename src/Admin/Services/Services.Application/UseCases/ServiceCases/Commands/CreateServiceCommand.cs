using MediatR;
using Services.Domain.Entities;

namespace Services.Application.UseCases.ServiceCases.Commands
{
    public class CreateServiceCommand : IRequest<ResponseModel>
    {
        public string Category { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
