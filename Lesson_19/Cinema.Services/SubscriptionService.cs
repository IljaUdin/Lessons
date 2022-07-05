using Cinema.DB;
using Cinema.Entities;
using Cinema.Services.Dto;
using Cinema.Services.Mapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Services
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly AppDbContext _context;
        private readonly IFilmMapper _mapper;

        public SubscriptionService(AppDbContext context, IFilmMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Task<List<SubscriptionDto>> GetSubscriptions()
        {
            return _context.Subscriptions.ProjectTo<SubscriptionDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public Task<SubscriptionDto> GetSubscriptionById(long id)
        {
            return _context.Subscriptions.ProjectTo<SubscriptionDto>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<long> Create(SubscriptionDto dto)
        {
            var entity = _mapper.Map<Subscription>(dto);
            await _context.Subscriptions.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity.Id;
        }

        public async Task UpdateSubscription(SubscriptionDto dto)
        {
            var entity = await _context.Subscriptions.FirstOrDefaultAsync(x => x.Id == dto.Id);

            if (entity is null)
            {
                throw new Exception($" Объект с id: {entity.Id} не найден");
            }
            _mapper.Map(dto, entity);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteSubscription(long id)
        {
            var entity = await _context.Subscriptions.FirstOrDefaultAsync(x => x.Id == id);
            _context.Subscriptions.Remove(entity);

            await _context.SaveChangesAsync();
        }
    }
}
