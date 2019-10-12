using projecten3_1920_backend_klim03.Domain.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.DTOs
{
    public class KlasDTO
    {
        public long KlasId { get; set; }

        public string Naam { get; set; }

        public long SchoolId { get; set; }

        public ICollection<ProjectDTO> Projecten { get; set; } = new List<ProjectDTO>();

        public KlasDTO()
        {

        }

        public KlasDTO(Klas klas)
        {
            KlasId = klas.KlasId;
            Naam = klas.Naam;
            SchoolId = klas.SchoolId;
            Projecten = klas.Projecten.Select(g => new ProjectDTO(g)).ToList();
        }
    }
}
