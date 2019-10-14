using System;
using Microsoft.AspNetCore.Mvc;
using projecten3_1920_backend_klim03.Domain.Models.Domain;
using projecten3_1920_backend_klim03.Domain.Models.DTOs;
using projecten3_1920_backend_klim03.Domain.Models.Interfaces;

namespace projecten3_1920_backend_klim03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class SchoolController : ControllerBase
    {
        private readonly ISchoolRepo _schools;

        public SchoolController(ISchoolRepo schools)
        {
            _schools = schools;
        }



        /// <summary>
        /// Get the school with its project templates for given id
        /// </summary>
        /// <param name="schoolId">the id of the school</param>
        /// <returns>The school with its project templates</returns>
        [HttpGet("withProjectTemplates/{schoolId}")]
        public ActionResult<SchoolDTO> GetClassRoomWithProjects(long schoolId)
        {
            return new SchoolDTO(_schools.GetByIdWithProjectTemplates(schoolId));
        }


        /// <summary>
        /// Adding a project teplate to a given school
        /// </summary>
        /// <param name="dto">The project template details</param>
        /// <param name="schoolId">the id of the school</param>
        /// <returns>The added project template</returns>
        [HttpPost("addProjectTemplate/{schoolId}")]
        public ActionResult<ProjectTemplateDTO> AddProject([FromBody]ProjectTemplateDTO dto, long schoolId)
        {

            School s = _schools.GetById(schoolId);
            ProjectTemplate pt = new ProjectTemplate(dto, true); // boolean (addedByGO) dependant on logged in user

            s.AddProjectTemplate(pt);
            _schools.SaveChanges();

            return new ProjectTemplateDTO(pt);
        }



    }
}
