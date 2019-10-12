using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class Project
    {
        public long ProjectId { get; set; }

        public string ProjectNaam { get; set; }
        public string ProjectOmschijving { get; set; }
        public string ProjectCode { get; set; } // om project met leerling te linken
        public string ProjectAfbeelding { get; set; }

        public bool StandaardProject { get; set; } // geeft aan of dit een project is die door het GO is aangemaakt

        public long KlasId { get; set; }
        public Klas Klas { get; set; }

        public long ToepassingsGebiedId { get; set; }
        public ToepassingsGebied ToepassingsGebied { get; set; }

        public ICollection<Product> Producten { get; set; } = new List<Product>();
        public ICollection<Groep> Groepen { get; set; } = new List<Groep>();
    }
}
