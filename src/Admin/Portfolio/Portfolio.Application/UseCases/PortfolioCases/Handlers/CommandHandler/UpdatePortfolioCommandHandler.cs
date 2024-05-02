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
    public class UpdatePortfolioCommandHandler : IRequestHandler<UpdatePortfolioCommand, ResponseModel>
    {
        private readonly IPortfolioDbContext _context;

        public UpdatePortfolioCommandHandler(IPortfolioDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(UpdatePortfolioCommand request, CancellationToken cancellationToken)
        {
            var Portfolio = await _context.Portfolios.FirstOrDefaultAsync(x => x.Id ==  request.Id);

            if (Portfolio != null)
            {
                Portfolio.Category = request.Category;
                Portfolio.Title = request.Title;
                Portfolio.Body = request.Body;

                _context.Portfolios.Update(Portfolio);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    StatusCode = 201,
                    IsSuccess = true,
                    Message = $"News with given id:{Portfolio.Id} is Succesfully Updated!"
                };
            }

            return new ResponseModel
            {
                StatusCode = 400,
                Message = $"Portfolio Not found"
            };
        }
    }
}
