using Dealers.Domain.Entities;
using MediatR;

namespace Dealers.Application.UseCases.DealerCases.Commands
{
    public class UpdateDealerCommand : IRequest<ResponseModel>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.Now;
    }
}
