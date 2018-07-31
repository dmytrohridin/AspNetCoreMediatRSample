using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreMediatRSample.Commands;
using AspNetCoreMediatRSample.Models;
using AspNetCoreMediatRSample.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMediatRSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator mediator;

        public OrdersController(IMediator mediator) => 
            this.mediator = mediator;

        [HttpGet]
        public async Task<IEnumerable<Order>> Get() => 
            await mediator.Send(new GetOrdersQuery());

        [HttpGet("{id}")]
        public async Task<Order> Get(Guid id) => 
            await mediator.Send(new GetOrderQuery(id));

        [HttpPost]
        public async Task<Guid> Create([FromBody] Order order) => 
            await mediator.Send(new CreateOrderCommand(order));

        [HttpDelete("{id}")]
        public async Task<bool> Delete(Guid id) =>
            await mediator.Send(new RemoveOrderCommand(id));
    }
}