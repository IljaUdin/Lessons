using Microsoft.AspNetCore.Mvc;
using Cinema.Services;
using Cinema.Services.Dto;

namespace Cinema.API.Controllers
{
    [ApiController]
    [Route("Country")]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _service;
        public CountryController(ICountryService service)
        {
            _service = service;
        }
        [HttpGet]
        public Task<List<CountryDto>> Get()
        {
            return _service.GetCountries();
        }

        [HttpGet("{id:long}")]
        public Task<CountryDto> GetById(long id)
        {
            return _service.GetCountryById(id);
        }

        [HttpPost]
        public Task<long> Create([FromBody] CountryDto dto)
        {
            return _service.Create(dto);
        }

        [HttpPut]
        public Task Update([FromBody] CountryDto dto)
        {
            return _service.UpdateCountry(dto);
        }

        [HttpDelete("{id:long}")]
        public Task Delete(long id)
        {
            return _service.DeleteCountry(id);
        }
    }
}
