using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class ClassRoom
    {
        public long ClassRoomId { get; set; }

        public string Name { get; set; }

        public long SchoolId { get; set; }
        public School School { get; set; }

        public ICollection<Project> Projects { get; set; } = new List<Project>();



        public void AddProject(Project p)
        {
            Projects.Add(p);
        }

        public ClassRoom()
        {

        }


    }
}
