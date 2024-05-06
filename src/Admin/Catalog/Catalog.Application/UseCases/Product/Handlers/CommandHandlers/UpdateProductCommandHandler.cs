using Catalog.Application.Abstractions;
using Catalog.Application.UseCases.Product.Commands;
using Catalog.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System;

namespace Catalog.Application.UseCases.Product.Handlers.CommandHandlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, ResponseModel>
    {
        private readonly ICatalogDbContext _context;

        public UpdateProductCommandHandler(ICatalogDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (product != null)
            {
                product.Name = request.Name;
                product.Model = request.Model;
                product.IsOnSale = request.IsOnSale;
                product.Price = request.Price;
                product.TypeMontage = request.TypeMontage;
                product.IP = request.IP;
                product.Potok = request.Potok;
                product.Power = request.Power;
                product.Temperature = request.Temperature;
                product.EmergencyBlock = request.EmergencyBlock;
                product.Management = request.Management;
                product.CRI = request.CRI;
                product.CatalogId = request.CatalogId;
                product.CategoryId = request.CategoryId;

                _context.Products.Update(product);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    Message = "Succesfully Updated",
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
