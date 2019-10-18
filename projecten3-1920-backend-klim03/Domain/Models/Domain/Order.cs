using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class Order
    {
        public long OrderId { get; set; }

        public DateTime Time { get; set; }
        public bool Finalised { get; set; } 

        public long GroupId { get; set; }
        public Group Group { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public void AddOrderItem(OrderItem oi)
        {
            OrderItems.Add(oi);
        }

        public void RemoveOrderItem(OrderItem oi)
        {
            OrderItems.Remove(oi);
        }

        public double GetOrderPrice()
        {
            return OrderItems.Select(g => g.Product.Price * g.Amount).Sum();
        }

        public OrderItem GetOrderItemById(long id)
        {
            return OrderItems.SingleOrDefault(g => g.OrderItemId == id);
        }

    }
}
