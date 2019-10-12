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

        public string ProjectNaam { get; set; }
        public string ProjectOmschijving { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectAfbeelding { get; set; }

        public long KlasId { get; set; }
        public Klas Klas { get; set; }

        public long ToepassingsGebiedId { get; set; }
        public ToepassingsGebied ToepassingsGebied { get; set; }

        public ICollection<ProductDTO> Producten { get; set; } = new List<ProductDTO>();
        public ICollection<GroepDTO> Groepen { get; set; } = new List<GroepDTO>();


        public ProjectDTO()
        {

        }

        public ProjectDTO(Project project)
        {
            ProjectId = project.ProjectId;

            ProjectNaam = project.ProjectNaam;
            ProjectOmschijving = project.ProjectOmschijving;
            ProjectCode = project.ProjectCode;
            ProjectAfbeelding = project.ProjectAfbeelding;

            KlasId = project.KlasId;
            ToepassingsGebiedId = project.ToepassingsGebiedId;

            Producten = project.Producten.Select(g => new ProductDTO(g)).ToList();
            Groepen = project.Groepen.Select(g => new GroepDTO(g)).ToList();
        }
    }
}
