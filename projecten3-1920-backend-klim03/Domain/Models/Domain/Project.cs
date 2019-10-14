using projecten3_1920_backend_klim03.Domain.Models.Domain.enums;
using projecten3_1920_backend_klim03.Domain.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class Project
    {
        public long ProjectId { get; set; }

        public string ProjectName { get; set; }
        public string ProjectDescr { get; set; }
        public string ProjectCode { get; set; } // om project met leerling te linken
        public string ProjectImage { get; set; }
        public ESchoolGrade ESchoolYear { get; set; }

        public long ClassRoomId { get; set; }
        public ClassRoom ClassRoom { get; set; }

        public long ApplicationDomainId { get; set; }
        public ApplicationDomain ApplicationDomain { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
        public ICollection<Group> Groups { get; set; } = new List<Group>();

        public Project()
        {

        }
    


        public Project(ProjectDTO dto)
        {
            ProjectName = dto.ProjectName;
            ProjectDescr = dto.ProjectDescr;
            ProjectCode = dto.ProjectCode;
            ProjectImage = dto.ProjectImage;
            ESchoolYear = dto.ESchoolYear;

            ApplicationDomainId = dto.ApplicationDomainId;

            dto.Products.ToList().ForEach(g => AddProduct(new Product(g)));
            dto.Groups.ToList().ForEach(g => AddGroup(new Group(g)));
        }


        public void AddProduct(Product p)
        {
            Products.Add(p);
        }

        public void AddGroup(Group g)
        {
            Groups.Add(g);
        }




    }
}
