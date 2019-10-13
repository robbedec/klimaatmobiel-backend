using System;
using Microsoft.AspNetCore.Mvc;
using projecten3_1920_backend_klim03.Domain.Models.DTOs;
using projecten3_1920_backend_klim03.Domain.Models.Interfaces;

namespace projecten3_1920_backend_klim03.Controllers
{
    [Route("api/[controller]")] // misschien niet nodig als je vanuit een groep gaat
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class GroupController
    {
        private readonly IGroupRepo _groups;

        public GroupController(IGroupRepo groups)
        {
            _groups = groups;
        }





        [HttpGet("{groupId}")]
        public ActionResult<GroupDTO> GetGroep(long groupId)
        {
            return new GroupDTO(_groups.GetById(groupId));
        }


    }
}
