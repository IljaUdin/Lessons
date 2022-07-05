using Cinema.DB;
using Cinema.Entities;
using Cinema.Services.Dto;
using Cinema.Services.Mapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Services
{
    public class FilmService : IFilmService
    {
        private readonly AppDbContext _context;
        private readonly IFilmMapper _mapper;

        public FilmService(AppDbContext context, IFilmMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Task<List<FilmDto>> GetFilms()
        {
            return _context.Films.ProjectTo<FilmDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public Task<FilmDto> GetFilmById(long id)
        {
            return _context.Films.ProjectTo<FilmDto>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<long> Create(FilmDto dto)
        {
            var entity = _mapper.Map<Film>(dto);
            await _context.Films.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity.Id;
        }

        public async Task UpdateFilm(FilmDto dto)
        {
            var entity = await _context.Films.FirstOrDefaultAsync(x=>x.Id == dto.Id);

            if (entity is null)
            {
                throw new Exception($" Объект с id: {entity.Id} не найден");
            }
            _mapper.Map(dto, entity);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteFilm(long id)
        {
            var entity = await _context.Films.FirstOrDefaultAsync(x => x.Id == id);
            _context.Films.Remove(entity);

            await _context.SaveChangesAsync();
        }
    }
}