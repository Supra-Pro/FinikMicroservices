using MediatR;
using Portfolio.Domain.Entities;

namespace Portfolio.Application.UseCases.PortfolioCases.Commands
{
    public class UpdatePortfolioCommand : IRequest<ResponseModel>
    {
        public Guid Id { get; set; }
        public string Category { get; set; }
        // shu joyida image bilan ishlangan joyi bolishi kere
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
