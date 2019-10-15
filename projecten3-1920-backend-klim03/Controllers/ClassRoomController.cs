using Microsoft.AspNetCore.Mvc;
using projecten3_1920_backend_klim03.Domain.Models.Domain;
using projecten3_1920_backend_klim03.Domain.Models.DTOs;
using projecten3_1920_backend_klim03.Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Controllers
{
    [Route("api/[controller]")] // misschien niet nodig als je vanuit een groep gaat
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class ClassRoomController : ControllerBase
    {
        private readonly IClassRoomRepo _classRooms;

        public ClassRoomController(IClassRoomRepo classRooms)
        {
            _classRooms = classRooms;
        }

        /// <summary>
        /// Get the classRoom with its projects for given id
        /// </summary>
        /// <param name="classRoomId">the id of the classroom</param>
        /// <returns>The classroom with its projects</returns>
        [HttpGet("withProjects/{classRoomId}")]
        public ActionResult<ClassRoomDTO> GetClassRoomWithProjects(long classRoomId)
        {
            return new ClassRoomDTO(_classRooms.GetByIdWithProjects(classRoomId));
        }


        /// <summary>
        /// Adding a project to a given classroom
        /// </summary>
        /// <param name="dto">The project details</param>
        /// <param name="classRoomId">the id of the classroom</param>
        /// <returns>The added project</returns>
        [HttpPost("addProject/{classRoomId}")]
        public ActionResult<ProjectDTO> AddProject([FromBody]ProjectDTO dto, long classRoomId)
        {

            ClassRoom cr = _classRooms.GetById(classRoomId);
            if (cr == null)
            {
                return NotFound();
            }
            Project p = new Project(dto);

            cr.AddProject(p);
            _classRooms.SaveChanges();

            return new ProjectDTO(p);
        }


       
    }
}
