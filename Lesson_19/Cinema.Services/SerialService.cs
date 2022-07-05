using Cinema.DB;
using Cinema.Entities;
using Cinema.Services.Dto;
using Cinema.Services.Mapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Services
{
    public class SerialService : ISerialService
    {
        private readonly AppDbContext _context;
        private readonly IFilmMapper _mapper;

        public SerialService(AppDbContext context, IFilmMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Task<List<SerialDto>> GetSerials()
        {
            return _context.Serials.ProjectTo<SerialDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public Task<SerialDto> GetSerialById(long id)
        {
            return _context.Serials.ProjectTo<SerialDto>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<long> Create(SerialDto dto)
        {
            var entity = _mapper.Map<Serial>(dto);
            await _context.Serials.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity.Id;
        }

        public async Task UpdateSerial(SerialDto dto)
        {
            var entity = await _context.Serials.FirstOrDefaultAsync(x => x.Id == dto.Id);

            if (entity is null)
            {
                throw new Exception($" Объект с id: {entity.Id} не найден");
            }
            _mapper.Map(dto, entity);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteSerial(long id)
        {
            var entity = await _context.Serials.FirstOrDefaultAsync(x => x.Id == id);
            _context.Serials.Remove(entity);

            await _context.SaveChangesAsync();
        }
    }
}
