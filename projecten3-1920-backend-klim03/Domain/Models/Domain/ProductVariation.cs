using System;
using projecten3_1920_backend_klim03.Domain.Models.Domain.enums;
using projecten3_1920_backend_klim03.Domain.Models.DTOs;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class ProductVariation
    {
        public string ProductVariationId { get; set; }

        public string ProductName { get; set; }
        public string ProductDescr { get; set; }
        public decimal Price { get; set; } 
        public ESchoolYear ESchoolYear { get; set; }


        public ProductVariation()
        {

        }

    

    }
}
