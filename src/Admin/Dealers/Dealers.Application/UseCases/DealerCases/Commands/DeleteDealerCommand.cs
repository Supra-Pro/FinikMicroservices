using Dealers.Domain.Entities;
using MediatR;

namespace Dealers.Application.UseCases.DealerCases.Commands
{
    public class DeleteDealerCommand : IRequest<ResponseModel>
    {
        public Guid Id { get; set; }
    }
}
