using MediatR;
using Projects.Domain.Eintities;

namespace Projects.Application.UseCases.ProjectCases.Commands
{
    public class CreateProjectCommand : IRequest<ResponseModel>
    {
        public string Category { get; set; }
        // rasm qoshadigan joyi.
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
