using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class CategorieTemplate
    {
        public long CategorieTemplateId { get; set; }

        public string CategorieNaam { get; set; }
        public string CategorieOmschrijving { get; set; }

        public ICollection<ProductTemplate> ProductTemplates { get; set; } = new List<ProductTemplate>();
        public ICollection<ProjectTemplate> ProjectTemplates { get; set; } = new List<ProjectTemplate>();
    }
}
