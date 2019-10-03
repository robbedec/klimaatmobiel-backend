using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class Product
    {
        public long ProductId { get; set; }

        public string ProductNaam { get; set; }
        public string ProductOmschrijving { get; set; } 
        public string ProductAfbeelding { get; set; }
        public decimal Prijs { get; set; }

        public bool StandaardProduct { get; set; } // geeft aan of dit een product is die door het GO is aangemaakt

        public long CategorieId { get; set; }
        public Categorie Categorie { get; set; }
    }
}
