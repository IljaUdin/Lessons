using Cinema.DB;
using Cinema.Entities;
using Cinema.Services.Dto;
using Cinema.Services.Mapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly AppDbContext _context;
        private readonly IFilmMapper _mapper;

        public CompanyService(AppDbContext context, IFilmMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Task<List<CompanyDto>> GetCompanies()
        {
            return _context.Companies.ProjectTo<CompanyDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public Task<CompanyDto> GetCompanyById(long id)
        {
            return _context.Companies.ProjectTo<CompanyDto>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<long> Create(CompanyDto dto)
        {
            var entity = _mapper.Map<Company>(dto);
            await _context.Companies.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity.Id;
        }

        public async Task UpdateCompany(CompanyDto dto)
        {
            var entity = await _context.Companies.FirstOrDefaultAsync(x => x.Id == dto.Id);

            if (entity is null)
            {
                throw new Exception($" Объект с id: {entity.Id} не найден");
            }
            _mapper.Map(dto, entity);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteCompany(long id)
        {
            var entity = await _context.Companies.FirstOrDefaultAsync(x => x.Id == id);
            _context.Companies.Remove(entity);

            await _context.SaveChangesAsync();
        }
    }
}
