using ArchitecturePageRequests.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturePageRequests.Application.UseCases.Queries
{
    public class GetAllRequestsQuery : IRequest<List<RequestModel>>
    {

    }
}
