using projecten3_1920_backend_klim03.Domain.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.DTOs
{
    public class ProjectDTO
    {
        public long ProjectId { get; set; }

        public string ProjectName { get; set; }
        public string ProjectDescr { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectImage { get; set; }

        public long ClassRoomId { get; set; }

        public long ApplicationDomainId { get; set; }
        public ApplicationDomain ApplicationDomain { get; set; }

        public ICollection<ProductDTO> Products { get; set; } = new List<ProductDTO>();
        public ICollection<GroupDTO> Groups { get; set; } = new List<GroupDTO>();


        public ProjectDTO()
        {

        }

        public ProjectDTO(Project project)
        {
            ProjectId = project.ProjectId;

            ProjectName = project.ProjectName;
            ProjectDescr = project.ProjectDescr;
            ProjectCode = project.ProjectCode;
            ProjectImage = project.ProjectImage;

            ClassRoomId = project.ClassRoomId;
            ApplicationDomainId = project.ApplicationDomainId;
            ApplicationDomain = project.ApplicationDomain;

            Products = project.Products.Select(g => new ProductDTO(g)).ToList();
            Groups = project.Groups.Select(g => new GroupDTO(g)).ToList();
        }
    }
}
