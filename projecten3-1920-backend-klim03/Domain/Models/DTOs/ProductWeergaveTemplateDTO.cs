using projecten3_1920_backend_klim03.Domain.Models.Domain;
using projecten3_1920_backend_klim03.Domain.Models.Domain.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.DTOs
{
    public class ProductWeergaveTemplateDTO
    {
        public long ProductWeergaveTemplateId { get; set; }

        public string ProductNaam { get; set; }
        public string ProductOmschrijving { get; set; }
        public ELeerjaar ELeerJaar { get; set; }

        public ProductWeergaveTemplateDTO()
        {

        }
        public ProductWeergaveTemplateDTO(ProductWeergaveTemplate pwt)
        {
            ProductWeergaveTemplateId = pwt.ProductWeergaveTemplateId;

            ProductNaam = pwt.ProductNaam;
            ProductOmschrijving = pwt.ProductOmschrijving;
            ELeerJaar = pwt.ELeerJaar;

        }
    }
}
