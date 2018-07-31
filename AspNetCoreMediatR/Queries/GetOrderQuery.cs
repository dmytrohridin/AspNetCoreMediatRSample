using System;
using AspNetCoreMediatRSample.Models;
using MediatR;

namespace AspNetCoreMediatRSample.Queries
{
    public class GetOrderQuery : IRequest<Order>
    {
        public GetOrderQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}
