using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.CustomExceptions
{
    public class DomainArgumentNullException : ArgumentNullException
    {
        public DomainArgumentNullException()
        {
        }

        public DomainArgumentNullException(string message)
            : base(message)
        {
        }

        public DomainArgumentNullException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
