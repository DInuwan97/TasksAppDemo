using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasksApp.Models;

namespace TasksApp.Services.Todos
{
    public class MockTodoServices : ITodoRepository
    {
        public List<Todo> AllTodos(int authorId)
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

        public Todo GetTodo(int authorId, int id)
        {
            throw new NotImplementedException();
        }
        public Todo AddTodo(int authorId, Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}
