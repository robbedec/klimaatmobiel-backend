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
    public class ClassRoomController
    {
        private readonly IClassRoomRepo _classRooms;

        public ClassRoomController(IClassRoomRepo classRooms)
        {
            _classRooms = classRooms;
        }


        [HttpGet("withProjects")]
        public ActionResult<ClassRoomDTO> GetClassRoomWithProjects(long groupId)
        {
            return new ClassRoomDTO(_classRooms.GetByIdWithProjects(groupId));
        }


        [HttpPost("addProject")]
        public ActionResult<ProjectDTO> AddProject([FromBody]ProjectDTO dto, long classRoomId)
        {

            ClassRoom cr = _classRooms.GetById(dto.ClassRoomId);
            Project p = new Project(dto);

            cr.AddProject(p);
            _classRooms.SaveChanges();

            return new ProjectDTO(p);
        }


       
    }
}
