﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApp.DataAccess;
using TasksApp.Models;

namespace TasksApp.Services
{
    class TodoSqlService : ITodoRepository
    {
        private readonly TodoDBContext _context = new TodoDBContext();
        public List<Todo> AllTodos()
        {
            return _context.Todos.ToList();
        }
    }
}
