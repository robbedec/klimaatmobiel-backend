using System;
using projecten3_1920_backend_klim03.Domain.Models.Domain;

namespace projecten3_1920_backend_klim03.Domain.Models.DTOs
{
    public class GroupDTO
    {
        public long GroupId { get; set; }

        public string GroupName { get; set; }
        public long ProjectId { get; set; }

        public OrderDTO Order { get; set; }

        public GroupDTO()
        {

        }
        public GroupDTO(Group group)
        {
            GroupId = group.GroupId;

            GroupName = group.GroupName;
            ProjectId = group.ProjectId;
            

            //if(Order != null)
            //{
                Order = new OrderDTO(group.Order);
            //}       
        }
    }
}
