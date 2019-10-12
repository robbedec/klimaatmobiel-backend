using projecten3_1920_backend_klim03.Domain.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.DTOs
{
    public class ProjectTemplateDTO
    {
        public long ProjectTemplateId { get; set; }

        public string ProjectNaam { get; set; }
        public string ProjectOmschijving { get; set; }
        public string ProjectAfbeelding { get; set; }
        public bool AddedByGO { get; set; }

        public long ToepassingsGebiedId { get; set; }
        public ToepassingsGebied ToepassingsGebied { get; set; }

        public ICollection<ProductTemplateDTO> ProductTemplates { get; set; } = new List<ProductTemplateDTO>();

        public ProjectTemplateDTO()
        {

        }

        public ProjectTemplateDTO(ProjectTemplate pt)
        {
            ProjectTemplateId = pt.ProjectTemplateId;

            ProjectNaam = pt.ProjectNaam;
            ProjectOmschijving = pt.ProjectOmschijving;
            ProjectAfbeelding = pt.ProjectAfbeelding;
            AddedByGO = pt.AddedByGO;

            ToepassingsGebiedId = pt.ToepassingsGebiedId;
            ToepassingsGebied = pt.ToepassingsGebied;

            ProductTemplates = pt.ProductTemplateProjectTemplates.Select(g => new ProductTemplateDTO(g.ProductTemplate)).ToList();

        }
    }
}
