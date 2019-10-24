using projecten3_1920_backend_klim03.Domain.Models.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace projecten3_1920_backend_klim03.Tests.Data
{
    public class DummyApplicationDbContext
    {
        public Order testOrder { get; }
        public OrderItem testOrderItem { get; }

        public DummyApplicationDbContext()
        {
            Product testP1 = new Product
            {
                ProductId = 1,
                ProductName = "Karton",
                Description = "Karton beschrijving",
                Price = 5
            };

            Product testP2 = new Product
            {
                ProductId = 2,
                ProductName = "Plastiek",
                Description = "plastiek beschrijving",
                Price = 20
            };

            Product testP3 = new Product
            {
                ProductId = 3,
                ProductName = "Lijm",
                Description = "Lijm beschrijving",
                Price = 8.5
            };

            OrderItem testOrderItem1 = new OrderItem
            {
                OrderItemId = 1,
                Product = testP1,
                Amount = 2
            };

            OrderItem testOrderItem2 = new OrderItem
            {
                OrderItemId = 2,
                Product = testP2,
                Amount = 1
            };

            OrderItem testOrderItem3 = new OrderItem
            {
                OrderItemId = 3,
                Product = testP3,
                Amount = 3
            };

            testOrderItem = new OrderItem
            {
                OrderItemId = 4,
                Product = testP1,
                Amount = 5
            };

            testOrder = new Order
            {
                OrderId = 1,
                Approved = false,
                Submitted = false,
                OrderItems = new List<OrderItem>
                {
                    testOrderItem1,
                    testOrderItem2,
                    testOrderItem3
                }
            };
        }
    }
}
