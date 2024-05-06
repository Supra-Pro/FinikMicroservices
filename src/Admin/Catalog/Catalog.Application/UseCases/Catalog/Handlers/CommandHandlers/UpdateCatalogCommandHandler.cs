using Catalog.Application.Abstractions;
using Catalog.Application.UseCases.Catalog.Commands;
using Catalog.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Application.UseCases.Catalog.Handlers.CommandHandlers
{
    public class UpdateCatalogCommandHandler : IRequestHandler<UpdateCatalogCommand, ResponseModel>
    {
        private readonly ICatalogDbContext _context;

        public UpdateCatalogCommandHandler(ICatalogDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(UpdateCatalogCommand request, CancellationToken cancellationToken)
        {
            var catalog = await _context.Catalogs.FirstOrDefaultAsync(x =>x.Id ==  request.CatalogId);

            if (catalog != null)
            {
                catalog.CatalogName = request.CatalogName;


                _context.Catalogs.Update(catalog);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    Message = "Succesfully Updated!",
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
