using System;
using Microsoft.AspNetCore.Mvc;

namespace projecten3_1920_backend_klim03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class ToepassingsGebiedController : ControllerBase
    {

        public ToepassingsGebiedController()
        {
        }
    }
}
