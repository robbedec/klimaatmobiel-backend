using projecten3_1920_backend_klim03.Domain.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace projecten3_1920_backend_klim03.Domain.Models.DTOs
{
    public class OrderDTO
    {
        public long OrderId { get; set; }

        public DateTime Time { get; set; }
        public bool Finalised { get; set; }

        public long GroupId { get; set; }

        public ICollection<OrderItemDTO> OrderItems { get; set; } = new List<OrderItemDTO>();

        public OrderDTO()
        {

        }

        public OrderDTO(Order order)
        {
            OrderId = order.OrderId;

            Time = order.Time;
            Finalised = order.Finalised;

            GroupId = order.GroupId;

            OrderItems = order.OrderItems.Select(g => new OrderItemDTO(g)).ToList();
        }
    }
}
