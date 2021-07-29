using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApp.Models;
using TasksApp.DataAccess;

namespace TasksApp.Services.Authors
{
    public class AuthorSqlServerService : IAuthorRepository
    {
        private readonly TodoDBContext _context = new TodoDBContext();
        public List<Author> GetAllAuthors()
        {
            return _context.Authors.ToList();
        }

        public List<Author> GetAuthors(String job, String search)
        {
            if (string.IsNullOrWhiteSpace(job) && string.IsNullOrWhiteSpace(search))
            {
                return GetAllAuthors();
            }

            var authorCollection = _context.Authors as IQueryable<Author>;

            if (!string.IsNullOrWhiteSpace(job))
            {
                job = job.Trim();
                authorCollection = authorCollection.Where(author => author.JobRole == job);
            }

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.Trim();
                authorCollection = authorCollection.Where(author => 
                author.FullName.Contains(search) || author.City.Contains(search));
            }
          
            return authorCollection.ToList();
            

        }

        public Author GetAuthor(int id)
        {
            return _context.Authors.Find(id);
        }

        public Author AddAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();

            return _context.Authors.Find(author.Id);
        }
    }
}
