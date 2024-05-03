using Dealers.Domain.Entities;
using MediatR;

namespace Dealers.Application.UseCases.DealerCases.Commands
{
    public class CreateDealerCommand : IRequest<ResponseModel>
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
