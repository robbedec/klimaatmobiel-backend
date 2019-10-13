using projecten3_1920_backend_klim03.Domain.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.DTOs
{
    public class ProductTemplateDTO
    {
        public long ProductTemplateId { get; set; }

        public string ProductImage { get; set; }
        public bool AddedByGO { get; set; }

        public long CategoryTemplateId { get; set; }
        public CategoryTemplate CategoryTemplate { get; set; }

        public ICollection<ProductVariationTemplateDTO> ProductVariationTemplates { get; set; } = new List<ProductVariationTemplateDTO>();

        public ProductTemplateDTO()
        {

        }

        public ProductTemplateDTO(ProductTemplate pt)
        {
            ProductTemplateId = pt.ProductTemplateId;

            ProductImage = pt.ProductImage;
            AddedByGO = pt.AddedByGO;

            CategoryTemplateId = pt.CategoryTemplateId;
            CategoryTemplate = pt.CategoryTemplate;

            ProductVariationTemplates = pt.ProductVariationTemplates.Select(g => new ProductVariationTemplateDTO(g)).ToList();
        }
    }
}
