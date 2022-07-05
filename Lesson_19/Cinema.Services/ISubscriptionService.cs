using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.Services.Dto;

namespace Cinema.Services
{
    public interface ISubscriptionService
    {
        public Task<List<SubscriptionDto>> GetSubscriptions();
        public Task<SubscriptionDto> GetSubscriptionById(long id);
        public Task<long> Create(SubscriptionDto dto);
        public Task UpdateSubscription(SubscriptionDto dto);
        public Task DeleteSubscription(long id);
    }
}
