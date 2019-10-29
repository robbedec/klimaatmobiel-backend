using System;
using Microsoft.AspNetCore.Mvc;
using projecten3_1920_backend_klim03.Domain.Models.Domain;
using projecten3_1920_backend_klim03.Domain.Models.DTOs;
using projecten3_1920_backend_klim03.Domain.Models.DTOs.AppDTOs;
using projecten3_1920_backend_klim03.Domain.Models.Interfaces;

namespace projecten3_1920_backend_klim03.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class GroupController : ControllerBase
    {
        private readonly IGroupRepo _groups;

        public GroupController(IGroupRepo groups)
        {
            _groups = groups;
        }



        /// <summary>
        /// Get the group for a given id
        /// </summary>
        /// <param name="groupId">the id of the group</param>
        /// <returns>The project</returns>
        [HttpGet("{groupId}")]
        public ActionResult<GroupDTO> GetGroep(long groupId)
        {
            try
            {
                return new GroupDTO(_groups.GetById(groupId));
            }
            catch (ArgumentNullException)
            {
                return NotFound(new CustomErrorDTO("Groep niet gevonden"));
            }
            
        }
        /// <summary>
        /// Get the group for a given groupCode with its order
        /// </summary>
        /// <param name="groupCode">the code of the group</param>
        /// <returns>The group with it's order</returns>
        [HttpGet("groupCode/{groupCode}")]
        public ActionResult<AppGroupDTO> GetGroepFromCode(string groupCode)
        {
            try
            {
                return new AppGroupDTO(_groups.GetByUniqueGroupCodeWithOrder(groupCode));
            }
            catch (ArgumentNullException)
            {
                return NotFound(new CustomErrorDTO("Groep niet gevonden"));
            }

        }

        /// <summary>
        /// Get the group with its project and order for a given groupCode
        /// </summary>
        /// <param name="groupCode">the code of the group</param>
        /// <returns>The group wit the project</returns>
        [HttpGet("project/{groupCode}")]
        public ActionResult<AppGroupDTO> GetGroupWithProjectAndOrder(string groupCode)
        {
            try
            {
                return new AppGroupDTO(_groups.GetByUniqueGroupCodeWithProjectAndOrder(groupCode));
            }
            catch (ArgumentNullException)
            {
                return NotFound(new CustomErrorDTO("Groep niet gevonden"));
            }

        }
    }
}
