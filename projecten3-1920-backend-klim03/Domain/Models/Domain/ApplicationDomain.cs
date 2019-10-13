using System;
using System.ComponentModel.DataAnnotations;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class ApplicationDomain
    {
        public long ApplicationDomainId { get; set; }
        
        public string ApplicationDomainName { get; set; }
        public string ApplicationDomainDescr { get; set; }



        public ApplicationDomain()
        {
        }
    }
}
