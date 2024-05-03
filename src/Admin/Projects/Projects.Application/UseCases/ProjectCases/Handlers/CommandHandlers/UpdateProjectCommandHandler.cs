using MediatR;
using Microsoft.EntityFrameworkCore;
using Projects.Application.Abstractions;
using Projects.Application.UseCases.ProjectCases.Commands;
using Projects.Domain.Eintities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Application.UseCases.ProjectCases.Handlers.CommandHandlers
{
    public class UpdateProjectCommandHandler : IRequestHandler<UpdateProjectCommand, ResponseModel>
    {
        private readonly IProjectDbContext _context;

        public UpdateProjectCommandHandler(IProjectDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _context.Projects.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (project != null)
            {
                project.Category = request.Category;
                project.Title = request.Title;
                project.Body = request.Body;

                _context.Projects.Update(project);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    Message = "Succesfully Updated!",
                    StatusCode = 400
                };
            }

            return new ResponseModel
            {
                Message = "Project not found!",
                StatusCode = 400
            };
        }
    }
}
