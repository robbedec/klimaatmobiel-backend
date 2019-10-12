using projecten3_1920_backend_klim03.Domain.Models.Domain;
using System;
namespace projecten3_1920_backend_klim03.Domain.Models.DTOs
{
    public class BestellingsItemDTO
    {
        public long BestellingsItemId { get; set; }

        public long Aantal { get; set; }

        public long ProductId { get; set; }
        public long BestellingId { get; set; }

        public BestellingsItemDTO()
        {
        }

        public BestellingsItemDTO(BestellingsItem bi) 
        {
            BestellingsItemId = bi.BestellingsItemId;

            Aantal = bi.Aantal;

            ProductId = bi.ProductId;
            BestellingId = bi.BestellingId;
        }
    }
}
