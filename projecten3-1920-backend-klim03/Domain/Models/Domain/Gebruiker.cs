using projecten3_1920_backend_klim03.Domain.Models.Domain.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class Gebruiker
    {
        public long GebruikerId { get; set; }

        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Email { get; set; }

        public EGebruikerType GebruikerType { get; set; }
    }
}
