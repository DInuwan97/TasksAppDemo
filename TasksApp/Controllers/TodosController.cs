using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasksApp.Services;

namespace TasksApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todoService;

        public TodosController(ITodoRepository repository)
        {
            _todoService = repository;
        }

        [HttpGet("{id?}")]
        public IActionResult GetTodos(int ? id)
        {

            var myTodos = _todoService.AllTodos();
            if (id == null) return Ok(myTodos);

            myTodos = _todoService.AllTodos().Where(t => t.Id == id).ToList();
            return Ok(myTodos);
        }

    
    }
}
