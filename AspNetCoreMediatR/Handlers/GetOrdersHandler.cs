using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AspNetCoreMediatRSample.Models;
using AspNetCoreMediatRSample.Queries;
using AspNetCoreMediatRSample.Repositories;
using MediatR;

namespace AspNetCoreMediatRSample.Handlers
{
    public class GetOrdersHandler : IRequestHandler<GetOrdersQuery, IEnumerable<Order>>
    {
        private readonly IOrderRepository orderRepository;

        public GetOrdersHandler(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public Task<IEnumerable<Order>> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
        {
            var orders = orderRepository.Get();

            return Task.FromResult(orders);
        }
    }
}
