using ContactPageRequests.Domain.Entities;
using MediatR;

namespace ContactPageRequests.Application.UseCases.Queries
{
    public class GetAllRequestsQuery : IRequest<List<RequestModel>>
    {

    }
}
