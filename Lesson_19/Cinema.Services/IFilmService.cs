using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.Entities;
using Cinema.Services.Dto;

namespace Cinema.Services
{
    public interface IFilmService
    {
        public Task<List<FilmDto>> GetFilms();
        public Task<FilmDto> GetFilmById(long id);
        public Task<long> Create(FilmDto dto);
        public Task UpdateFilm(FilmDto dto);
        public Task DeleteFilm(long id);
    }
}
