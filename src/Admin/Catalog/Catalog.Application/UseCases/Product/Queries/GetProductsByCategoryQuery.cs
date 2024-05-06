using Catalog.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.UseCases.Product.Queries
{
    public class GetProductsByCategoryQuery : IRequest<List<ProductModel>>
    {
        public int CategoryId { get; set; }
    }
}
