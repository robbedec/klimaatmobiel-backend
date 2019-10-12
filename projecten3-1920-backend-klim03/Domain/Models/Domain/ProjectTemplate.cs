using projecten3_1920_backend_klim03.Domain.Models.Domain.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class ProjectTemplate
    {
        public long ProjectTemplateId { get; set; }

        public string ProjectNaam { get; set; }
        public string ProjectOmschijving { get; set; }
        public string ProjectAfbeelding { get; set; }
        public bool AddedByGO { get; set; }

        public long ToepassingsGebiedId { get; set; }
        public ToepassingsGebied ToepassingsGebied { get; set; }

        public ICollection<ProductTemplateProjectTemplate> ProductTemplateProjectTemplates { get; set; } = new List<ProductTemplateProjectTemplate>();
    }
}
