using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using NJsonSchema;

namespace projecten3_1920_backend_klim03.Domain.Models.DTOs
{
    public class LoginDTO
    {
        // https://techbrij.com/asp-net-core-identity-login-email-username


        /// <example>
        /// "leerkracht"
        /// </example>
        [Required]
        public string UserName { get; set; }

        /// <example>
        /// "P@ssword1"
        /// </example>
        [Required]
        public string Password { get; set; }

    }
}
