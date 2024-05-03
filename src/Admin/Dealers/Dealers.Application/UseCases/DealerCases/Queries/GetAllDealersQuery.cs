using Dealers.Domain.Entities;
using MediatR;

namespace Dealers.Application.UseCases.DealerCases.Queries
{
    public class GetAllDealersQuery : IRequest<List<DealersModel>>
    {

    }
}
