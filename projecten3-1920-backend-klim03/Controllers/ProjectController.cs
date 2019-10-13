using System;
using Microsoft.AspNetCore.Mvc;
using projecten3_1920_backend_klim03.Domain.Models.DTOs;
using projecten3_1920_backend_klim03.Domain.Models.Interfaces;

namespace projecten3_1920_backend_klim03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectRepo _projects;

        public ProjectController(IProjectRepo projects)
        {
            _projects = projects;
        }


        [HttpGet("{projectId}")]
        public ActionResult<ProjectDTO> GetProject(long projectId)
        {
            return new ProjectDTO(_projects.GetById(projectId));
        }



        [HttpPut]
        public ActionResult<ProjectDTO> Put([FromBody] ProjectDTO dto)
        {
            var p = _projects.GetById(dto.ProjectId);

            p.ProjectName = dto.ProjectName;
            p.ProjectDescr = dto.ProjectDescr;
           
            p.ProjectCode = dto.ProjectCode;

            p.ClassRoomId = dto.ClassRoomId;
            p.ApplicationDomainId = dto.ApplicationDomainId;
           

            throw new NotImplementedException("update of groups and products not implemented yet");

            return new ProjectDTO(p);
        }



        [HttpDelete("{projectId}")]
        public ActionResult<ProjectDTO> DeleteProject(long id)
        {

            var delProject = _projects.GetById(id);
            _projects.Remove(delProject);
            _projects.SaveChanges();
            return new ProjectDTO(delProject);

        }



    }
}
