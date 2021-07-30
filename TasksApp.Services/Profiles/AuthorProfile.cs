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
    public class AuthorProfile  :Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorDto>()
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => $"{src.AddresNo}, {src.City}, {src.Street}"))
                .ForMember(dest => dest.Todos, opt => opt.MapFrom(src => src.Todos));
            CreateMap<CreateAuthorDto, Author>();
        }
    }
}
