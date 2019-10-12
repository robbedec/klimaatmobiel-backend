using System;
using Microsoft.AspNetCore.Mvc;
using projecten3_1920_backend_klim03.Domain.Models.DTOs;
using projecten3_1920_backend_klim03.Domain.Models.Interfaces;

namespace projecten3_1920_backend_klim03.Controllers
{
    [Route("api/[controller]")] // misschien niet nodig als je vanuit een groep gaat
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class GroepController
    {
        private readonly IGroepRepo _groepen;

        public GroepController(IGroepRepo groepen)
        {
            _groepen = groepen;
        }





        [HttpGet("{groepId}")]
        public ActionResult<GroepDTO> GetGroep(long groepId)
        {
            return new GroepDTO(_groepen.GetById(groepId));
        }


    }
}
