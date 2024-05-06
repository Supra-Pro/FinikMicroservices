using Catalog.Application.Abstractions;
using Catalog.Application.UseCases.Product.Commands;
using Catalog.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Application.UseCases.Product.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, ResponseModel>
    {
        private readonly ICatalogDbContext _context;

        public DeleteProductCommandHandler(ICatalogDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == request.ProductId);

            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    Message = "Succesfully Deleted!",
                    StatusCode = 201
                };
            }

            return new ResponseModel
            {
                Message = "Product not found!",
                StatusCode = 400
            };
        }
    }
}
