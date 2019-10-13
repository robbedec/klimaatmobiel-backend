using System;
using projecten3_1920_backend_klim03.Domain.Models.Domain.enums;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class ProductVariationTemplate
    {
        public long ProductVariationTemplateId { get; set; }

        public string ProductName { get; set; }
        public string ProductDescr { get; set; }
        public ESchoolYear ESchoolYear { get; set; }
    }
}
