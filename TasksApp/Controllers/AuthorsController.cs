using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasksApp.Services.Authors;
namespace TasksApp.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _repository;
        public AuthorsController(IAuthorRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authors = _repository.GetAllAuthors();
            return Ok(authors);
        }
        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id)
        {
            var author = _repository.GetAuthor(id);
            if (author == null) return NotFound();
            return Ok(author);
        }
    }
}
