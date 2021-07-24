using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasksApp.Models;

namespace TasksApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        [HttpGet("{id?}")]
        public IActionResult GetTodos(int ? id)
        {

            var myTodos = AllTodos();
            if (id == null) return Ok(myTodos);

            myTodos = AllTodos().Where(t => t.Id == id).ToList();
            return Ok(myTodos);
        }

        //get Todos
        private List<Todo> AllTodos()
        {

            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Get Books",
                Description = "Get books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New
            };
            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "Get Medicine",
                Description = "Get Medicine for sickness",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.InProgress
            };
            todos.Add(todo2);

            return todos;

        }
    }
}
