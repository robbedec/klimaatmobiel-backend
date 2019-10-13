using projecten3_1920_backend_klim03.Domain.Models.Domain;
using projecten3_1920_backend_klim03.Domain.Models.Domain.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.DTOs
{
    public class ProductVariationTemplateDTO
    {
        public long ProductVariationTemplateId { get; set; }

        public string ProductName { get; set; }
        public string ProductDescr { get; set; }
        public ESchoolYear ESchoolYear { get; set; }

        public ProductVariationTemplateDTO()
        {

        }
        public ProductVariationTemplateDTO(ProductVariationTemplate pvt)
        {
            ProductVariationTemplateId = pvt.ProductVariationTemplateId;

            ProductName = pvt.ProductName;
            ProductDescr = pvt.ProductDescr;
            ESchoolYear = pvt.ESchoolYear;

        }
    }
}
