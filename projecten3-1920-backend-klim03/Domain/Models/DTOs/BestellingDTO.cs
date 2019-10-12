using projecten3_1920_backend_klim03.Domain.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace projecten3_1920_backend_klim03.Domain.Models.DTOs
{
    public class BestellingDTO
    {
        public long BestellingId { get; set; }

        public DateTime Tijd { get; set; }
        public bool Afgerond { get; set; }

        public long GroepId { get; set; }

        public ICollection<BestellingsItemDTO> BestellingsItems { get; set; } = new List<BestellingsItemDTO>();

        public BestellingDTO()
        {

        }

        public BestellingDTO(Bestelling bestelling)
        {
            BestellingId = bestelling.BestellingId;

            Tijd = bestelling.Tijd;
            Afgerond = bestelling.Afgerond;

            GroepId = bestelling.GroepId;

            BestellingsItems = bestelling.BestellingsItems.Select(g => new BestellingsItemDTO(g)).ToList();
        }
    }
}
