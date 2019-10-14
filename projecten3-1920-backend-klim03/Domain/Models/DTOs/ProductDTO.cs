using projecten3_1920_backend_klim03.Domain.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace projecten3_1920_backend_klim03.Domain.Models.DTOs
{
    public class ProductDTO
    {
        public long ProductId { get; set; }

        public string ProductImage { get; set; }
        public bool HasMultipleDisplayVariations { get; set; }

        public long ProjectId { get; set; }

        public double Price { get; set; }

        public long CatergoryId { get; set; }
        public Category Category { get; set; }

        public ProductDTO()
        {
        }
        public ProductDTO(Product product)
        {
            ProductId = product.ProductId;
            ProductImage = product.ProductImage;

            ProjectId = product.ProjectId;
            CatergoryId = product.CatergoryId;
            Category = product.Category;

        }
    }
}
