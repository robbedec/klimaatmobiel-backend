using System;
namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class ApplicationDomain
    {
        public long ApplicationDomainId { get; set; }

        public string ApplicationDomainName { get; set; } // kan enum zijn
        public string ApplicationDomainDescr { get; set; }



        public ApplicationDomain()
        {
        }
    }
}
