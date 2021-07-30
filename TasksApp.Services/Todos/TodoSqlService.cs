using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApp.DataAccess;
using TasksApp.Models;

namespace TasksApp.Services.Todos
{
    public class TodoSqlService : ITodoRepository
    {
        private readonly TodoDBContext _context = new TodoDBContext();
        public List<Todo> AllTodos(int authorId)
        {
            return _context.Todos.Where(todo => todo.AuthorId == authorId).ToList();
        }

        public Todo GetTodo(int authorId,int id)
        {
            return _context.Todos.FirstOrDefault(todo => todo.AuthorId == authorId && todo.Id == id);
        }

        public Todo AddTodo(int authorId,Todo todo)
        {
            todo.AuthorId = authorId;
            _context.Todos.Add(todo);
            _context.SaveChanges();

            return _context.Todos.Find(todo.Id);
        }
    }
}
