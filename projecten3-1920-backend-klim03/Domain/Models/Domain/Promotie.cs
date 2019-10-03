using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class Promotie
    {
        public long PromotieId { get; set; }

        public string Titel { get; set; }
        public string Omschrijving { get; set; }

        public Promotie()
        {

        }
    }
}
