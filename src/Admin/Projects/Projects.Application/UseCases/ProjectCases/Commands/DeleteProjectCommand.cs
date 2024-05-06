using MediatR;
using Projects.Domain.Eintities;

namespace Projects.Application.UseCases.ProjectCases.Commands
{
    public class DeleteProjectCommand : IRequest<ResponseModel>
    {
        public Guid Id { get; set; }
    }
}
