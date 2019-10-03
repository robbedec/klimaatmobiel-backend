using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class Bestelling
    {
        public long BestellingId { get; set; }

        public DateTime Tijd { get; set; }

        public long GroepId { get; set; }
        public Groep Groep { get; set; }

        public ICollection<BestellingsItem> BestellingsItems { get; set; } = new List<BestellingsItem>();

        public Bestelling()
        {

        }


        public decimal BerekekenPrijsMetPromotie()
        {
            throw new NotImplementedException();
        }

    }
}
