using Cinema.DB;
using Cinema.Entities;
using Cinema.Services.Dto;
using Cinema.Services.Mapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Services
{
    public class CountryService : ICountryService
    {
        private readonly AppDbContext _context;
        private readonly IFilmMapper _mapper;

        public CountryService(AppDbContext context, IFilmMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Task<List<CountryDto>> GetCountries()
        {
            return _context.Countries.ProjectTo<CountryDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public Task<CountryDto> GetCountryById(long id)
        {
            return _context.Countries.ProjectTo<CountryDto>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<long> Create(CountryDto dto)
        {
            var entity = _mapper.Map<Country>(dto);
            await _context.Countries.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity.Id;
        }

        public async Task UpdateCountry(CountryDto dto)
        {
            var entity = await _context.Countries.FirstOrDefaultAsync(x => x.Id == dto.Id);

            if (entity is null)
            {
                throw new Exception($" Объект с id: {entity.Id} не найден");
            }
            _mapper.Map(dto, entity);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteCountry(long id)
        {
            var entity = await _context.Countries.FirstOrDefaultAsync(x => x.Id == id);
            _context.Countries.Remove(entity);

            await _context.SaveChangesAsync();
        }
    }
}
