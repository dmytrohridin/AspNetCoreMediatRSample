using System;
using System.Collections.Generic;
using AspNetCoreMediatRSample.Models;

namespace AspNetCoreMediatRSample.Repositories
{
    public interface IOrderRepository
    {
        IEnumerable<Order> Get();

        Order Get(Guid id);

        Guid Create(Order order);

        bool Remove(Guid id);
    }
}