using System;
using Microsoft.AspNetCore.Mvc;
using projecten3_1920_backend_klim03.Domain.Models.Interfaces;

namespace projecten3_1920_backend_klim03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class ToepassingsGebiedController : ControllerBase
    {
        private readonly IToepassingsGebiedRepo _tgs;

        public ToepassingsGebiedController(IToepassingsGebiedRepo tgs)
        {
            _tgs = tgs;
        }


    }
}
