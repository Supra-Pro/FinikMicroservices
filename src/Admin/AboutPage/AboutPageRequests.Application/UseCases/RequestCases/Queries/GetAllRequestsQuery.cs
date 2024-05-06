using AboutPageRequests.Domain.Entities;
using MediatR;

namespace AboutPageRequests.Application.UseCases.RequestCases.Queries
{
    public class GetAllRequestsQuery : IRequest<List<RequestModel>>
    {

    }
}
