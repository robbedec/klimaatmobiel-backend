using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class Categorie
    {
        public long CategorieId { get; set; }

        public string CategorieNaam { get; set; }
        public string CategorieOmschrijving { get; set; }

        public bool StandaardCategorie { get; set; } // geeft aan of dit een categorie is die door het GO is aangemaakt

        public ICollection<Product> Producten { get; set; } = new List<Product>();
    }
}
