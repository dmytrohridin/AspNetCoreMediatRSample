using System.Collections.Generic;
using AspNetCoreMediatRSample.Models;
using MediatR;

namespace AspNetCoreMediatRSample.Queries
{
    public class GetOrdersQuery : IRequest<IEnumerable<Order>>
    {
    }
}
