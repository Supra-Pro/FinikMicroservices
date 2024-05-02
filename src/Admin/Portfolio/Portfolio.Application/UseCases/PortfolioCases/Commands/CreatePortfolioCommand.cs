using MediatR;
using Portfolio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.UseCases.PortfolioCases.Commands
{
    public class CreatePortfolioCommand : IRequest<ResponseModel>
    {
        public string Category { get; set; }
        // shu joyida image bilan ishlangan joyi bolishi kere
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
