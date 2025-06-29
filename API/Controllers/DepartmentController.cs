using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllDepartment()
        {
            return Ok("get all students");
        }
        // Route Param
        [HttpGet("{id}")]
        public IActionResult GetDepartmentById(Guid id)
        {
            return Ok("get this dep = id  = "+id.ToString());
        }
        /*  Query Param
         [HttpGet]
        public IActionResult GetDepartmentById([FromQuery] Guid id)
        {
            return Ok($"get this dep = id = {id}");
        }

         */

        [HttpPost("{code}")]
        public IActionResult PostCommentaire(string code)
        {
           return Ok("updated sussuful "+code);
        }

        [HttpDelete]
        public IActionResult DeleteCommentaire()
        {
            return Ok("deleted sussuful ");
        }
    }
}
