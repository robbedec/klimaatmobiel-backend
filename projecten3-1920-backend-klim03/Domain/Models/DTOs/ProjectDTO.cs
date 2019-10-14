using projecten3_1920_backend_klim03.Domain.Models.Domain;
using projecten3_1920_backend_klim03.Domain.Models.Domain.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.DTOs
{
    public class ProjectDTO
    {
        public long ProjectId { get; set; }

        [Required]
        public string ProjectName { get; set; }
        [Required]
        public string ProjectDescr { get; set; }
        [Required]
        public string ProjectCode { get; set; }
        public string ProjectImage { get; set; }
        [Required]
        public ESchoolYear ESchoolYear { get; set; }
        [Required]
        public long ClassRoomId { get; set; }

        [Required]
        public long ApplicationDomainId { get; set; }
        public ApplicationDomainDTO ApplicationDomain { get; set; }

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
            ESchoolYear = project.ESchoolYear;

            ApplicationDomainId = project.ApplicationDomainId;
            ApplicationDomain = new ApplicationDomainDTO(project.ApplicationDomain);

            Products = project.Products.Select(g => new ProductDTO(g)).ToList();
            Groups = project.Groups.Select(g => new GroupDTO(g)).ToList();
        }



    }
}
