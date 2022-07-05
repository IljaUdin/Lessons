using Microsoft.AspNetCore.Mvc;
using Cinema.Services;
using Cinema.Services.Dto;

namespace Cinema.Controllers
{
    [ApiController]
    [Route("Film")]
    public class FilmController : ControllerBase
    {
        private readonly IFilmService _service;
        public FilmController(IFilmService service)
        {
            _service = service;
        }
        [HttpGet]
        public Task<List<FilmDto>> Get()
        {
            return _service.GetFilms();
        }

        [HttpGet("{id:long}")]
        public Task<FilmDto> GetById(long id)
        {
            return _service.GetFilmById(id);
        }

        [HttpPost]
        public Task<long> Create([FromBody] FilmDto dto)
        {
            return _service.Create(dto);
        }

        [HttpPut]
        public Task Update([FromBody] FilmDto dto)
        {
            return _service.UpdateFilm(dto);
        }

        [HttpDelete("{id:long}")]
        public Task Delete(long id)
        {
            return _service.DeleteFilm(id);
        }
    }
}
