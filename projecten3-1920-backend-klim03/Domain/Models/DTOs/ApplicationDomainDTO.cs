using projecten3_1920_backend_klim03.Domain.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.DTOs
{
    public class ApplicationDomainDTO
    {
        public long ApplicationDomainId { get; set; }
        [Required]
        public string ApplicationDomainName { get; set; }
        [Required]
        public string ApplicationDomainDescr { get; set; }

        public ApplicationDomainDTO()
        {

        }

        public ApplicationDomainDTO(ApplicationDomain ad)
        {
            ApplicationDomainId = ad.ApplicationDomainId;

            ApplicationDomainName = ad.ApplicationDomainName;
            ApplicationDomainDescr = ad.ApplicationDomainDescr;
        }
    }
}
