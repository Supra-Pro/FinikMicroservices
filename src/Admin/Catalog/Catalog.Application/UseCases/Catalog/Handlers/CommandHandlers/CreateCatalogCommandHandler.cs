using Catalog.Application.Abstractions;
using Catalog.Application.UseCases.Catalog.Commands;
using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.UseCases.Catalog.Handlers.CommandHandlers
{
    public class CreateCatalogCommandHandler : IRequestHandler<CreateCatalogCommand, ResponseModel>
    {
        private readonly ICatalogDbContext _context;

        public CreateCatalogCommandHandler(ICatalogDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(CreateCatalogCommand request, CancellationToken cancellationToken)
        {
            if (request != null)
            {
                var catalog = new CatalogModel
                {
                    CatalogName = request.CatalogName,
                };

                await _context.Catalogs.AddAsync(catalog);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    Message = $"Catalog {request.CatalogName} is Created!",
                    StatusCode = 201
                };
            }

            return new ResponseModel
            {
                Message = "Catalog isn't created!",
                StatusCode = 400
            };
        }
    }
}
