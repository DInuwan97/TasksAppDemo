using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApp.Models;

namespace TasksApp.Services.Authors
{
    public interface IAuthorRepository
    {
        public List<Author> GetAllAuthors();
        public List<Author> GetAuthors(String job, String search);
        public Author GetAuthor(int id);
    }
}
