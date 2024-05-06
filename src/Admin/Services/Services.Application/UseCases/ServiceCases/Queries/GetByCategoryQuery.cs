using MediatR;
using Services.Domain.Entities;

namespace Services.Application.UseCases.ServiceCases.Queries
{
    public class GetByCategoryQuery : IRequest<List<ServiceModel>>
    {
        public string Category { get; set; }
    }
}
