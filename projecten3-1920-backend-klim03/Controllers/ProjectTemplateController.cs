using Microsoft.AspNetCore.Mvc;
using projecten3_1920_backend_klim03.Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class ProjectTemplateController : ControllerBase
    {
        private readonly IProjectTemplateRepo _projectTemplates;

        public ProjectTemplateController(IProjectTemplateRepo projectTemplates)
        {
            _projectTemplates = projectTemplates;
        }
    }
}
