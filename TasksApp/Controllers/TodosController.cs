using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasksApp.Models;
using TasksApp.Services.DTOs;
using TasksApp.Services.Todos;

namespace TasksApp.Controllers
{
    [Route("api/authors/{authorId}/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todoService;
        private readonly IMapper _mapper;

        public TodosController(ITodoRepository repository, IMapper mapper)
        {
            _todoService = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<TodosDto>> GetTodos(int authorId)
        {
            var todos = _todoService.AllTodos(authorId);
            var mappedTodos = _mapper.Map<ICollection<TodosDto>>(todos);
            return Ok(mappedTodos);
        }

        [HttpGet("{id}", Name ="GetTodo")]
        public ActionResult<TodosDto> GetTodo(int authorId,int id)
        {
            var todo = _todoService.GetTodo(authorId,id);
            var mappedTodo = _mapper.Map<TodosDto>(todo);
            if (mappedTodo == null) return NotFound();
            return Ok(mappedTodo);
        }


        [HttpPost]
        public ActionResult<TodosDto> CreateTodo(int authorId,CreateTodoDto todo)
        {
            var todoEntity = _mapper.Map<Todo>(todo);
            var newTodo = _todoService.AddTodo(authorId, todoEntity);

            var todoForReturn = _mapper.Map<TodosDto>(newTodo);
            return CreatedAtRoute("GetTodo", new { authorId = authorId, id = todoForReturn.Id }, todoForReturn);
        }

    
    }
}
