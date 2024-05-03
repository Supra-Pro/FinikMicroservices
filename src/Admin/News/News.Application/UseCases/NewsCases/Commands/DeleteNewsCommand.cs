using MediatR;
using News.Domain.Entities;

namespace News.Application.UseCases.NewsCases.Commands
{
    public class DeleteNewsCommand : IRequest<ResponseModel>
    {
        public Guid Id { get; set; }
    }
}
