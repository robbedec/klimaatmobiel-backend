using projecten3_1920_backend_klim03.Domain.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace projecten3_1920_backend_klim03.Domain.Models.DTOs
{
    public class ProductDTO
    {
        public long ProductId { get; set; }

        public string ProductAfbeelding { get; set; }
        public bool HeeftMeerdereProductWeergaves { get; set; }

        public ICollection<ProductWeergave> ProductWeergaves { get; set; } = new List<ProductWeergave>();

        public long ProjectId { get; set; }

        public long CategorieId { get; set; }
        public Categorie Categorie { get; set; }

        public ProductDTO()
        {
        }
        public ProductDTO(Product product)
        {
            ProductId = product.ProductId;
            ProductAfbeelding = product.ProductAfbeelding;
            HeeftMeerdereProductWeergaves = product.HeeftMeerdereProductWeergaves;

            ProjectId = product.ProjectId;
            CategorieId = product.CategorieId;
            Categorie = product.Categorie;

            ProductWeergaves = product.ProductWeergaves;
        }
    }
}
