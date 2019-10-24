using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.DTOs
{
    public class CustomErrorDTO
    {
        public string Error { get; set; }

        public CustomErrorDTO()
        {

        }
        public CustomErrorDTO(string error)
        {
            Error = error;
        }
    }
}
