using System.Threading;
using System.Threading.Tasks;
using AspNetCoreMediatRSample.Commands;
using AspNetCoreMediatRSample.Repositories;
using MediatR;

namespace AspNetCoreMediatRSample.Handlers
{
    public class RemoveOrderHandler : IRequestHandler<RemoveOrderCommand, bool>
    {
        private readonly IOrderRepository orderRepository;

        public RemoveOrderHandler(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public Task<bool> Handle(RemoveOrderCommand request, CancellationToken cancellationToken)
        {
            var result = orderRepository.Remove(request.Id);
            return Task.FromResult(result);
        }
    }
}
