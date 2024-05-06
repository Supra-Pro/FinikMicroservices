using Catalog.Application.Abstractions;
using Catalog.Application.UseCases.Product.Commands;
using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.UseCases.Product.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ResponseModel>
    {
        private readonly ICatalogDbContext _context;

        public CreateProductCommandHandler(ICatalogDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            if (request != null)
            {
                var product = new ProductModel
                {
                    Name = request.Name,
                    Model = request.Model,
                    IsOnSale = request.IsOnSale,
                    Price = request.Price,
                    TypeMontage = request.TypeMontage,
                    IP = request.IP,
                    Potok = request.Potok,
                    Power = request.Power,
                    Temperature = request.Temperature,
                    EmergencyBlock = request.EmergencyBlock,
                    Management = request.Management,
                    CRI = request.CRI,
                    CatalogId = request.CatalogId,
                    CategoryId = request.CategoryId,
                };

                await _context.Products.AddAsync(product);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    Message = $"Product {product.Name} is Created!",
                    StatusCode = 201
                };
            }

            return new ResponseModel
            {
                Message = "Product isn't Created!",
                StatusCode = 400
            };
        }
    }
}
