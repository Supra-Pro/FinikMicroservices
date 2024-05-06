using ArchitecturePageRequests.Domain.Entities;
using MediatR;

namespace ArchitecturePageRequests.Application.UseCases.Queries
{
    public class GetAllRequestsQuery : IRequest<List<RequestModel>>
    {

    }
}
