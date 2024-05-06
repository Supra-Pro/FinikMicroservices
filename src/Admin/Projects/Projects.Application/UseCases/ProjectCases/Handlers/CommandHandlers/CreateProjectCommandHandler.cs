using MediatR;
using Projects.Application.Abstractions;
using Projects.Application.UseCases.ProjectCases.Commands;
using Projects.Domain.Eintities;

namespace Projects.Application.UseCases.ProjectCases.Handlers.CommandHandlers
{
    public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, ResponseModel>
    {
        private readonly IProjectDbContext _context;

        public CreateProjectCommandHandler(IProjectDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            if (request != null)
            {
                var Project = new ProjectsModel
                {
                    Category = request.Category,
                    Title = request.Title,
                    Body = request.Body,
                };

                await _context.Projects.AddAsync(Project);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    Message = "Succesfully Created!",
                    StatusCode = 201
                };

            }
            return new ResponseModel
            {
                Message = "Error",
                StatusCode = 400
            };
        }
    }
}
