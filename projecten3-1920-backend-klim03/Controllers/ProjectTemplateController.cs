using Microsoft.AspNetCore.Mvc;
using projecten3_1920_backend_klim03.Domain.Models.DTOs;
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

        /// <summary>
        /// Get the project template with given id
        /// </summary>
        /// <param name="projectId">the id of the project template</param>
        /// <returns>The project template</returns>
        [HttpGet("{projectId}")]
        public ActionResult<ProjectTemplateDTO> GetProjectTemplate(long projectId)
        {
            return new ProjectTemplateDTO(_projectTemplates.GetById(projectId));
        }

        /// <summary>
        /// updates a project template
        /// </summary>
        /// <param name="projectTemplateId">id of the project template to be modified</param>
        /// <param name="dto">the modified project template</param>
        [HttpPut("{projectTemplateId}")]
        public ActionResult<ProjectTemplateDTO> Put([FromBody] ProjectTemplateDTO dto, long projectTemplateId)
        {
            var pt = _projectTemplates.GetById(projectTemplateId);

            pt.ProjectName = dto.ProjectName;
            pt.ProjectDescr = dto.ProjectDescr;
            pt.ProjectImage = dto.ProjectImage;

            pt.ApplicationDomainId = dto.ApplicationDomainId;


            throw new NotImplementedException("update of productTemplatess not implemented yet");
            _projectTemplates.SaveChanges();

            return new ProjectTemplateDTO(pt);
        }


        /// <summary>
        /// Deletes a project template
        /// </summary>
        /// <param name="projectTemplateId">the id of the project template to be deleted</param>
        [HttpDelete("{projectTemplateId}")]
        public ActionResult<ProjectTemplateDTO> DeleteProject(long projectTemplateId)
        {

            var delProjectTemplate = _projectTemplates.GetById(projectTemplateId);
            _projectTemplates.Remove(delProjectTemplate);
            _projectTemplates.SaveChanges();
            return new ProjectTemplateDTO(delProjectTemplate);

        }








    }
}
