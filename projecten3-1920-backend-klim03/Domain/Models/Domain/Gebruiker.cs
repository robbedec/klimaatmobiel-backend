using Microsoft.AspNetCore.Identity;
using projecten3_1920_backend_klim03.Domain.Models.Domain.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class Gebruiker : IdentityUser<int>
    {
       
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }

        public GebruikerType GebruikerType { get; set; }
    }
}
