using MediatR;
using Projects.Domain.Eintities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Application.UseCases.ProjectCases.Queries
{
    public class GetProjectsByCategoryQuery : IRequest<List<ProjectsModel>>
    {
        public string Category { get; set; }
    }
}
