using MediatR;
using News.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Application.UseCases.NewsCases.Commands
{
    public class DeleteNewsCommand : IRequest<ResponseModel>
    {
        public Guid Id { get; set; }
    }
}
