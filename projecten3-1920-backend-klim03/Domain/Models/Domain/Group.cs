using projecten3_1920_backend_klim03.Domain.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class Group
    {
        public long GroupId { get; set; }

        public string GroupName { get; set; }

        public Order Order { get; set; }

        public long ProjectId { get; set; }
        public Project Project { get; set; }

        public Group()
        {
          
        }

        public Group(GroupDTO dto)
        {
            GroupName = dto.GroupName;
            InitOrder();
        }

        public void InitOrder()
        {
            Order = new Order
            {   
            };
        }

    }
}
