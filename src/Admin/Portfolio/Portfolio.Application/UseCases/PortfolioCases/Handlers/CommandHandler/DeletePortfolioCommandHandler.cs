using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Application.Abstractions;
using Portfolio.Application.UseCases.PortfolioCases.Commands;
using Portfolio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.UseCases.PortfolioCases.Handlers.CommandHandler
{
    public class DeletePortfolioCommandHandler : IRequestHandler<DeleteportfolioCommand, ResponseModel>
    {
        private readonly IPortfolioDbContext _context;

        public DeletePortfolioCommandHandler(IPortfolioDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(DeleteportfolioCommand request, CancellationToken cancellationToken)
        {
            var Portfolio = await _context.Portfolios.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (Portfolio != null)
            {
                _context.Portfolios.Remove(Portfolio);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    StatusCode = 201,
                    IsSuccess = true,
                    Message = "Succesfully Deleted!"
                };
            }
            return new ResponseModel
            {
                StatusCode = 400,
                Message = "Not Found"
            };
        }
    }
}
