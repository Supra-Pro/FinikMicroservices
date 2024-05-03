using MediatR;
using Portfolio.Domain.Entities;

namespace Portfolio.Application.UseCases.PortfolioCases.Commands
{
    public class DeleteportfolioCommand : IRequest<ResponseModel>
    {
        public Guid Id { get; set; }
    }
}
