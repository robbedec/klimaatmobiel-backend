using System;
using Microsoft.AspNetCore.Mvc;
using projecten3_1920_backend_klim03.Domain.Models.Interfaces;

namespace projecten3_1920_backend_klim03.Controllers
{
    [Route("api/[controller]")] // misschien niet nodig als je vanuit een groep gaat
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class BestellingController : ControllerBase
    {
        private readonly IBestellingRepo _bestellingen;

        public BestellingController(IBestellingRepo bestellingen)
        {
            _bestellingen = bestellingen;
        }


    }
}
