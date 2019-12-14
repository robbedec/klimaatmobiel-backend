using projecten3_1920_backend_klim03.Domain.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.DTOs
{
    public class ClassRoomDTO
    {
        public long ClassRoomId { get; set; }

        public string Name { get; set; }

        public long SchoolId { get; set; }

        public ICollection<ProjectDTO> Projects { get; set; } = new List<ProjectDTO>();

        public int ProjectsAmount { get; set; }

        public ClassRoomDTO()
        {

        }

        public ClassRoomDTO(ClassRoom c, bool includeProjects = true)
        {
            ClassRoomId = c.ClassRoomId;
            Name = c.Name;
            SchoolId = c.SchoolId;
            if (includeProjects)
            {
                Projects = c.Projects.Select(g => new ProjectDTO(g)).ToList();
            }
            ProjectsAmount = c.Projects.Count;
        }
    }
}
