using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksApp.Services.DTOs
{
    public class CreateAuthorDto
    {
        public String FullName { get; set; }
        public String AddresNo { get; set; }
        public String Street { get; set; }
        public String City { get; set; }
        public String JobRole { get; set; }
        public ICollection<CreateTodoDto> Todos { get; set; } = new List<CreateTodoDto>();
    }
}
