using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain.ManyToMany
{
    public class ProductTemplateProjectTemplate
    {
        public long ProjectTemplateId { get; set; }
        public ProjectTemplate ProjectTemplate { get; set; }

        public long ProductTemplateId { get; set; }
        public ProductTemplate ProductTemplate { get; set; }

        public ProductTemplateProjectTemplate()
        {

        }
    }
}
