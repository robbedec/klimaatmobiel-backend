using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class Groep
    {
        public long GroepId { get; set; }

        public string Groepsnaam { get; set; }

        public Bestelling Bestelling { get; set; }

        public long ProjectId { get; set; }
        public Project Project { get; set; }

        public ICollection<Leerling> Leerlingen { get; set; } = new List<Leerling>();
    }
}
