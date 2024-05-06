using MediatR;
using Projects.Domain.Eintities;

namespace Projects.Application.UseCases.ProjectCases.Queries
{
    public class GetProjectsByCategoryQuery : IRequest<List<ProjectsModel>>
    {
        public string Category { get; set; }
    }
}
