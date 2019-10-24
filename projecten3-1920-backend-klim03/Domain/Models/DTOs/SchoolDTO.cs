using projecten3_1920_backend_klim03.Domain.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.DTOs
{
    public class SchoolDTO
    {
        public long SchoolId { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string TelNum { get; set; }

        public long AdresId { get; set; }
        public Adres Adres { get; set; }

        public ICollection<ClassRoomDTO> ClassRooms { get; set; } = new List<ClassRoomDTO>();

        public ICollection<ProjectTemplateDTO> ProjectTemplates { get; set; } = new List<ProjectTemplateDTO>();
        public ICollection<ProductTemplateDTO> ProductTemplates { get; set; } = new List<ProductTemplateDTO>();

        public SchoolDTO()
        {

        }

        public SchoolDTO(School school)
        {
            SchoolId = school.SchoolId;

            Name = school.Name;
            Email = school.Email;
            TelNum = school.TelNum;
            AdresId = school.AdresId;

            Adres = school.Adres;

            ClassRooms = school.ClassRooms.Select(g => new ClassRoomDTO(g)).ToList();
            ProjectTemplates = school.ProjectTemplates.Select(g => new ProjectTemplateDTO(g)).ToList();
            ProductTemplates = school.ProductTemplates.Select(g => new ProductTemplateDTO(g)).ToList();


        }
    }
}
