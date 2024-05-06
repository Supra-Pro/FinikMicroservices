using AboutPageRequests.Domain.Entities;
using MediatR;

namespace AboutPageRequests.Application.UseCases.RequestCases.Commands
{
    public class CreateRequestCommand : IRequest<ResponseModel>
    {
        public string Name { get; set; }
        public string CityOfImplementation { get; set; }
        public string PhoneNumber { get; set; }
        public string PlannedSales { get; set; }
    }
}
