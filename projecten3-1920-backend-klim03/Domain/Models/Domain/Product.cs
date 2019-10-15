using projecten3_1920_backend_klim03.Domain.Models.Domain.enums;
using projecten3_1920_backend_klim03.Domain.Models.Domain.ManyToMany;
using projecten3_1920_backend_klim03.Domain.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class Product
    {
        public long ProductId { get; set; }

        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }


        public long ProjectId { get; set; }
        public Project Project { get; set; }

        public long CatergoryId { get; set; }
        public Category Category { get; set; }

        public Product()
        {

        }

        public Product(ProductDTO dto)
        {
            ProductName = dto.ProductName;
            ProductImage = dto.ProductImage;
            Price = dto.Price;
            CatergoryId = dto.CatergoryId;
        }

        public Product(ProductTemplate pt)
        {
            ProductImage = pt.ProductImage;
            ProductName = pt.ProductName;

            Description = pt.ProductVariationTemplates.FirstOrDefault(g => g.ESchoolGrade == ESchoolGrade.ALGEMEEN).ProductDescr;
        }
    }
}
