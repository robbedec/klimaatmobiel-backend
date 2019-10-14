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

        /// <summary>
        /// Get the project with given id
        /// </summary>
        /// <param name="projectId">the id of the project</param>
        /// <returns>The project</returns>
        [HttpGet("{projectId}")]
        public ActionResult<ProjectDTO> GetProject(long projectId)
        {
            return new ProjectDTO(_projects.GetById(projectId));
        }

        /// <summary>
        /// updates a project
        /// </summary>
        /// <param name="projectId">id of the project to be modified</param>
        /// <param name="dto">the modified project</param>
        [HttpPut("{projectId}")]
        public ActionResult<ProjectDTO> Put([FromBody] ProjectDTO dto, long projectId)
        {
            var p = _projects.GetById(projectId);

            p.ProjectName = dto.ProjectName;
            p.ProjectDescr = dto.ProjectDescr;
           
            p.ProjectCode = dto.ProjectCode;

            p.ClassRoomId = dto.ClassRoomId;
            p.ApplicationDomainId = dto.ApplicationDomainId;

            throw new NotImplementedException("update of groups and products not implemented yet");
            _projects.SaveChanges();
            

            return new ProjectDTO(p);
        }


        /// <summary>
        /// Deletes a project
        /// </summary>
        /// <param name="projectId">the id of the project to be deleted</param>
        [HttpDelete("{projectId}")]
        public ActionResult<ProjectDTO> DeleteProject(long projectId)
        {

            var delProject = _projects.GetById(projectId);
            _projects.Remove(delProject);
            _projects.SaveChanges();
            return new ProjectDTO(delProject);

        }



    }
}
