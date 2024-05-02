using MediatR;
using Portfolio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.UseCases.PortfolioCases.Queries
{
    public class GetAllPortfoliosQuery : IRequest<List<PortfolioModel>>
    {

    }
}
