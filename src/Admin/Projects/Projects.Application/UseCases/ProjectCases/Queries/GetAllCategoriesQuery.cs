using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Application.UseCases.ProjectCases.Queries
{
    public class GetAllCategoriesQuery : IRequest<List<string>>
    {

    }
}
