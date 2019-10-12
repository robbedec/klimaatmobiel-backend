using System;
using projecten3_1920_backend_klim03.Domain.Models.Domain.enums;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class ProductWeergaveTemplate
    {
        public long ProductWeergaveTemplateId { get; set; }

        public string ProductNaam { get; set; }
        public string ProductOmschrijving { get; set; }
        public decimal Prijs { get; set; }
        public ELeerjaar ELeerJaar { get; set; }
    }
}
