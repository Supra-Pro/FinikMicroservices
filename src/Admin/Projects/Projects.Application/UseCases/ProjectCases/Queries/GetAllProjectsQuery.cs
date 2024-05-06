using MediatR;
using Projects.Domain.Eintities;

namespace Projects.Application.UseCases.ProjectCases.Queries
{
    public class GetAllProjectsQuery : IRequest<List<ProjectsModel>>
    {

    }
}
