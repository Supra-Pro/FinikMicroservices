using MediatR;
using Portfolio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.UseCases.PortfolioCases.Commands
{
    public class DeleteportfolioCommand : IRequest<ResponseModel>
    {
        public Guid Id { get; set; }
    }
}
