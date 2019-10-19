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
        public bool Finalized { get; set; } 

        public long GroupId { get; set; }
        public Group Group { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public decimal GetOrderPrice => (decimal)OrderItems.Select(g => g.Product.Price * g.Amount).Sum();

        public Order()
        {

        }

        public void AddOrderItem(OrderItem oi)
        {
            if (Finalized) throw new NotSupportedException("It is not allowed to change a finalized order");
            OrderItems.Add(oi);
        }

        public void RemoveOrderItem(OrderItem oi)
        {
            if (Finalized) throw new NotSupportedException("It is not allowed to change a finalized order");
            OrderItems.Remove(oi);
        }

        public OrderItem GetOrderItemById(long id)
        {
            return OrderItems.SingleOrDefault(g => g.OrderItemId == id);
        }

        public void Approve()
        {
            Group.PayOrder(GetOrderPrice);
        }

    }
}
