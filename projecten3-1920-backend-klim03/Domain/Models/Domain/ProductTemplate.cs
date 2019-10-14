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

        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public bool HasMultipleDisplayVariations { get; set; }

        public bool AddedByGO { get; set; }

        public long CategoryTemplateId { get; set; }
        public CategoryTemplate CategoryTemplate { get; set; }

        public long SchoolId { get; set; }
        public School School { get; set; }

        public ICollection<ProductVariationTemplate> ProductVariationTemplates { get; set; } = new List<ProductVariationTemplate>();

        public ICollection<ProductTemplateProjectTemplate> ProductTemplateProjectTemplates { get; set; } = new List<ProductTemplateProjectTemplate>();
    }
}
