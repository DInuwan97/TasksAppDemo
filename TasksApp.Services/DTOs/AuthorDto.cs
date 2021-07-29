using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksApp.Services.DTOs
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public String FullName { get; set; }
        public String Address { get; set; }
        public String JobRole { get; set; }

    }
}
