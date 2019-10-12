using System;
using projecten3_1920_backend_klim03.Domain.Models.Domain;

namespace projecten3_1920_backend_klim03.Domain.Models.DTOs
{
    public class GroepDTO
    {
        public long GroepId { get; set; }

        public string Groepsnaam { get; set; }
        public long ProjectId { get; set; }

        public BestellingDTO Bestelling { get; set; }

        public GroepDTO()
        {

        }
        public GroepDTO(Groep groep)
        {
            GroepId = groep.GroepId;

            Groepsnaam = groep.Groepsnaam;
            ProjectId = groep.ProjectId;

            Bestelling = new BestellingDTO(groep.Bestelling);
            
        }
    }
}
