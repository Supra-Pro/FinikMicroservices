using Catalog.Application.Abstractions;
using Catalog.Application.UseCases.Catalog.Commands;
using Catalog.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Application.UseCases.Catalog.Handlers.CommandHandlers
{
    public class DeleteCatalogCommandHandler : IRequestHandler<DeleteCatalogCommand, ResponseModel>
    {
        private readonly ICatalogDbContext _context;

        public DeleteCatalogCommandHandler(ICatalogDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(DeleteCatalogCommand request, CancellationToken cancellationToken)
        {
            var catalog = await _context.Catalogs.FirstOrDefaultAsync(x => x.Id == request.CatalogId);

            if (catalog != null)
            {
                _context.Catalogs.Remove(catalog);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    Message = "Succesfully Deleted!",
                    StatusCode = 201
                };
            }

            return new ResponseModel
            {
                Message = "Catalog not found!",
                StatusCode = 400
            };
        }
    }
}
