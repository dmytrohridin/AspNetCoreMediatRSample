using System;
using AspNetCoreMediatRSample.Models;
using MediatR;

namespace AspNetCoreMediatRSample.Commands
{
    public class CreateOrderCommand : IRequest<Guid>
    {
        public CreateOrderCommand(Order order)
        {
            Order = order;
        }

        public Order Order { get; }
    }
}
