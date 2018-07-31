using System;
using System.Threading;
using System.Threading.Tasks;
using AspNetCoreMediatRSample.Commands;
using AspNetCoreMediatRSample.Repositories;
using MediatR;

namespace AspNetCoreMediatRSample.Handlers
{
    public class CreateOrderHandler : IRequestHandler<CreateOrderCommand, Guid>
    {
        private readonly IOrderRepository orderRepository;

        public CreateOrderHandler(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public Task<Guid> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var id = orderRepository.Create(request.Order);
            return Task.FromResult(id);
        }
    }
}
