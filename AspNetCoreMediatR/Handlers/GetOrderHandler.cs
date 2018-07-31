using System.Threading;
using System.Threading.Tasks;
using AspNetCoreMediatRSample.Models;
using AspNetCoreMediatRSample.Queries;
using AspNetCoreMediatRSample.Repositories;
using MediatR;

namespace AspNetCoreMediatRSample.Handlers
{
    public class GetOrderHandler : IRequestHandler<GetOrderQuery, Order>
    {
        private readonly IOrderRepository orderRepository;

        public GetOrderHandler(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public Task<Order> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
            var result = orderRepository.Get(request.Id);

            return Task.FromResult(result);
        }
    }
}
