using System;

namespace AspNetCoreMediatRSample.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
