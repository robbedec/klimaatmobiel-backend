using projecten3_1920_backend_klim03.Domain.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.DTOs
{
    public class SchoolDTO
    {
        public long SchoolId { get; set; }

        public string Naam { get; set; }
        public string Email { get; set; }
        public string TelNummer { get; set; }

        public long AdresId { get; set; }
        public Adres Adres { get; set; }

        public ICollection<KlasDTO> Klassen { get; set; } = new List<KlasDTO>();

        public SchoolDTO()
        {

        }

        public SchoolDTO(School school)
        {
            SchoolId = school.SchoolId;

            Naam = school.Naam;
            Email = school.Email;
            TelNummer = school.TelNummer;
            AdresId = school.AdresId;

            Adres = school.Adres;
            Klassen = school.Klassen.Select(g => new KlasDTO(g)).ToList();

        }
    }
}
