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

        public string ProductAfbeelding { get; set; }
        public bool AddedByGO { get; set; }

        public long CategorieTemplateId { get; set; }
        public CategorieTemplate CategorieTemplate { get; set; }

        public ICollection<ProductWeergaveTemplateDTO> ProductWeergaveTemplates { get; set; } = new List<ProductWeergaveTemplateDTO>();

        public ProductTemplateDTO()
        {

        }

        public ProductTemplateDTO(ProductTemplate pt)
        {
            ProductTemplateId = pt.ProductTemplateId;

            ProductAfbeelding = pt.ProductAfbeelding;
            AddedByGO = pt.AddedByGO;

            CategorieTemplateId = pt.CategorieTemplateId;
            CategorieTemplate = pt.CategorieTemplate;

            ProductWeergaveTemplates = pt.ProductWeergaveTemplates.Select(g => new ProductWeergaveTemplateDTO(g)).ToList();
        }
    }
}
