using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class Leerling
    {
        public long LeerlingId { get; set; }

        public string Voornaam { get; set; }
        public string Achternaam { get; set; }

        public long KlasId { get; set; }
        public Klas Klas { get; set; }


    }
}
