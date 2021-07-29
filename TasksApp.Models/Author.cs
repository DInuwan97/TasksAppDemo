using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksApp.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public String FullName  { get; set; }
        [MaxLength(10)]
        public String AddresNo { get; set; }
        [MaxLength(200)]
        public String Street { get; set; }
        [Required]
        [MaxLength(50)]
        public String City { get; set; }
        public ICollection<Todo> Todos { get; set; }
    }
}
