using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApp.Models;
using TasksApp.Services.DTOs;

namespace TasksApp.Services.Profiles
{
    public class TodosProfile : Profile
    {
        public TodosProfile()
        {
            CreateMap<Todo, TodosDto>();
        }
    }
}
