using MediatR;
using Microsoft.EntityFrameworkCore;
using Projects.Application.Abstractions;
using Projects.Application.UseCases.ProjectCases.Commands;
using Projects.Domain.Eintities;

namespace Projects.Application.UseCases.ProjectCases.Handlers.CommandHandlers
{
    public class DeleteProjectCommandHandler : IRequestHandler<DeleteProjectCommand, ResponseModel>
    {
        private readonly IProjectDbContext _context;

        public DeleteProjectCommandHandler(IProjectDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _context.Projects.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (project != null)
            {
                _context.Projects.Remove(project);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    Message = "Succesfully Deleted!",
                    StatusCode = 201
                };
            }
            return new ResponseModel
            {
                Message = "Project Not Found",
                StatusCode = 400
            };
        }
    }
}
