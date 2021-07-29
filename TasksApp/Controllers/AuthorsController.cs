using AutoMapper;
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
        private readonly IMapper _mapper;
        public AuthorsController(IAuthorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<ICollection<AuthorDto>> GetAuthors()
        {
            var authors = _repository.GetAllAuthors();
            var mappedAuthors = _mapper.Map<ICollection<AuthorDto>>(authors);
            // var authorsDto = new List<AuthorDto>();
            /*  foreach(var author in authors)
              {
                  authorsDto.Add(new AuthorDto
                  {
                      Id = author.Id,
                      FullName = author.FullName,
                      Address = $"{author.AddresNo}, {author.City}, {author.Street}"
                  });
              }
            */
            return Ok(mappedAuthors);
        }
        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id)
        {
            var author = _repository.GetAuthor(id);
            var mappedAuthor = _mapper.Map<AuthorDto>(author);
            if (mappedAuthor == null) return NotFound();
            return Ok(mappedAuthor);
        }
    }
}
