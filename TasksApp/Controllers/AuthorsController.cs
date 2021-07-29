using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasksApp.Services.Authors;
using TasksApp.Services.DTOs;
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
        public ActionResult<ICollection<AuthorDto>> GetAuthors()
        {
            var authors = _repository.GetAllAuthors();
            var authorsDto = new List<AuthorDto>();

            foreach(var author in authors)
            {
                authorsDto.Add(new AuthorDto
                {
                    Id = author.Id,
                    FullName = author.FullName,
                    Address = $"{author.AddresNo}, {author.City}, {author.Street}"
                });
            }
            return Ok(authorsDto);
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
