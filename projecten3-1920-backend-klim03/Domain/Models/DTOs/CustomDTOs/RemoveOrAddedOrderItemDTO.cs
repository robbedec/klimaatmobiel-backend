using projecten3_1920_backend_klim03.Domain.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.DTOs.CustomDTOs
{
    public class RemoveOrAddedOrderItemDTO
    {
        public decimal TotalOrderPrice { get; set; }
        public OrderItemDTO RemovedOrAddedOrderItem { get; set; } // this is the orderItem that has been added or removed


        public RemoveOrAddedOrderItemDTO()
        {
        }


        public RemoveOrAddedOrderItemDTO(Order o, OrderItem oi)
        {
            TotalOrderPrice = o.GetOrderPrice;
            RemovedOrAddedOrderItem = new OrderItemDTO(oi);
        }
    }
}
