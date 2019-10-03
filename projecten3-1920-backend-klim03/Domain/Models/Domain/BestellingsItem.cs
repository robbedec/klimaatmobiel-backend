using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class BestellingsItem
    {
        public long BestellingsItemId { get; set; }

        public long Aantal { get; set; }

        public long ProductId { get; set; }
        public Product Product { get; set; }

        public long BestellingId { get; set; }
        public Bestelling Bestelling { get; set; }
    }
}
