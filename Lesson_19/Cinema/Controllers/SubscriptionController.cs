using Microsoft.AspNetCore.Mvc;
using Cinema.Services;
using Cinema.Services.Dto;

namespace Cinema.API.Controllers
{
    [ApiController]
    [Route("Subscription")]
    public class SubscriptionController : ControllerBase
    {
        private readonly ISubscriptionService _service;
        public SubscriptionController(ISubscriptionService service)
        {
            _service = service;
        }
        [HttpGet]
        public Task<List<SubscriptionDto>> Get()
        {
            return _service.GetSubscriptions();
        }

        [HttpGet("{id:long}")]
        public Task<SubscriptionDto> GetById(long id)
        {
            return _service.GetSubscriptionById(id);
        }

        [HttpPost]
        public Task<long> Create([FromBody] SubscriptionDto dto)
        {
            return _service.Create(dto);
        }

        [HttpPut]
        public Task Update([FromBody] SubscriptionDto dto)
        {
            return _service.UpdateSubscription(dto);
        }

        [HttpDelete("{id:long}")]
        public Task Delete(long id)
        {
            return _service.DeleteSubscription(id);
        }
    }
}
