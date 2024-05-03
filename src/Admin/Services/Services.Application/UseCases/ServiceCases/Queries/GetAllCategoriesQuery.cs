using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Application.UseCases.ServiceCases.Queries
{
    public class GetAllCategoriesQuery : IRequest<List<string>>
    {

    }
}
