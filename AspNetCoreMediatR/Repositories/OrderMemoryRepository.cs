using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreMediatRSample.Models;

namespace AspNetCoreMediatRSample.Repositories
{
    public class OrderMemoryRepository : IOrderRepository
    {
        private static List<Order> orders = new List<Order>
        {
            new Order {Id = Guid.NewGuid(), Name = "Order 1", CreationDate = DateTime.UtcNow},
            new Order {Id = Guid.NewGuid(), Name = "Order 2", CreationDate = DateTime.UtcNow}
        };

        public IEnumerable<Order> Get()
        {
            return orders;
        }

        public Order Get(Guid id)
        {
            return orders.FirstOrDefault(x => x.Id == id);
        }

        public Guid Create(Order order)
        {
            order.Id = Guid.NewGuid();
            orders.Add(order);

            return order.Id;
        }

        public bool Remove(Guid id)
        {
            var updatedOrders = orders.Where(x => x.Id != id).ToList();
            if (updatedOrders.Count == orders.Count) return false;

            orders = new List<Order>(updatedOrders);
            return true;
        }
    }
}
