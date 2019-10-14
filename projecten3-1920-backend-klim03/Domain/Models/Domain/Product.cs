﻿using projecten3_1920_backend_klim03.Domain.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class Product
    {
        public long ProductId { get; set; }

        public string ProductImage { get; set; }
        public bool HasMultipleDisplayVariations { get; set; }
        public string Description { get; set; }


        public long ProjectId { get; set; }
        public Project Project { get; set; }

        public long CatergoryId { get; set; }
        public Category Category { get; set; }

        public Product()
        {

        }

        public Product(ProductDTO dto)
        {
            ProductImage = dto.ProductImage;
            HasMultipleDisplayVariations = dto.HasMultipleDisplayVariations;

            CatergoryId = dto.CatergoryId;
        }
    }
}
