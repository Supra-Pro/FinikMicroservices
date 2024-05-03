using MediatR;
using Projects.Domain.Eintities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Application.UseCases.ProjectCases.Commands
{
    public class DeleteProjectCommand : IRequest<ResponseModel>
    {
        public Guid Id { get; set; }
    }
}
