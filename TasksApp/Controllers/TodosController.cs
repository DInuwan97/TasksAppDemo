using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasksApp.Services.Todos;

namespace TasksApp.Controllers
{
    [Route("api/authors/{authorId}/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todoService;

        public TodosController(ITodoRepository repository)
        {
            _todoService = repository;
        }

        [HttpGet]
        public IActionResult GetTodos(int authorId)
        {
            var todos = _todoService.AllTodos(authorId);
            return Ok(todos);
        }

        [HttpGet("{id}")]
        public IActionResult GetTodo(int id)
        {
            var myTodos = _todoService.GetTodo(id);
            if (myTodos == null) return NotFound();
            return Ok(myTodos);
        }

    
    }
}
