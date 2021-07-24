using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TasksApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Tasks()
        {
            var tasks = new string[] { "Task 1", "Task 2", "Task 2" };
            return Ok(tasks);
        }

        [HttpPost]
        public IActionResult NewTasks()
        {
            var task = "task" ;
            return Ok();
        }

        //this is update cmt
        //
        [HttpPut]
        public IActionResult UpdateTask()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTask()
        {
            var someThingWentWrong = false;
            if (someThingWentWrong)
                return Ok();
            return BadRequest();
        }
    }
}
