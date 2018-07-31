using System;
using MediatR;

namespace AspNetCoreMediatRSample.Commands
{
    public class RemoveOrderCommand : IRequest<bool>
    {
        public RemoveOrderCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}
