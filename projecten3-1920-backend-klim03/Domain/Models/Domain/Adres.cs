using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class Adres
    {
        public long AdresId { get; set; }
        public string Postcode { get; set; }
        public string Plaats { get; set; }
        public string Straat { get; set; }
        public string Huisnummer { get; set; }

    }
}
