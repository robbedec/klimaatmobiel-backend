using projecten3_1920_backend_klim03.Domain.Models.Domain.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class ProductTemplate
    {
        public long ProductTemplateId { get; set; }

        public string ProductNaam { get; set; }
        public string ProductOmschrijving { get; set; }
        public string ProductAfbeelding { get; set; }
        public bool Standaard { get; set; }

        public long CategorieTemplateId { get; set; }
        public CategorieTemplate CategorieTemplate { get; set; }

        public ICollection<ProductTemplateProjectTemplate> ProductTemplateProjectTemplates { get; set; } = new List<ProductTemplateProjectTemplate>();
    }
}
