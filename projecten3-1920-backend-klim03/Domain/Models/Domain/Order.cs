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



    }
}
