﻿using System;
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

        public Todo GetTodo(int id)
        {
            return _context.Todos.Find(id);
        }
    }
}
