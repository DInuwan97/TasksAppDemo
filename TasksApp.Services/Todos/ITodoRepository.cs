using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApp.Models;

namespace TasksApp.Services.Todos
{
    public interface ITodoRepository
    {
        public List<Todo> AllTodos();

        public Todo GetTodo(int id);
    }
}
