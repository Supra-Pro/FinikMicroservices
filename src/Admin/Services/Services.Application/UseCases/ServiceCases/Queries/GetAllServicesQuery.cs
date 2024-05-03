using MediatR;
using Services.Domain.Entities;

namespace Services.Application.UseCases.ServiceCases.Queries
{
    public class GetAllServicesQuery : IRequest<List<ServiceModel>>
    {

    }
}
