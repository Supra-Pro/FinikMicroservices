﻿using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.UseCases.Product.Commands
{
    public class CreateProductCommand : IRequest<ResponseModel>
    {
        public string Name { get; set; }
        // Picture qowadga joyi
        public string Model { get; set; }
        public bool IsOnSale { get; set; }
        public int Price { get; set; }
        public string TypeMontage { get; set; }
        public string IP { get; set; }
        public string Potok { get; set; }
        public int Power { get; set; }
        public int Temperature { get; set; }
        public string EmergencyBlock { get; set; }
        public string Management { get; set; }
        public string CRI { get; set; }
        public int CatalogId { get; set; }
        public int CategoryId { get; set; }
    }
}
