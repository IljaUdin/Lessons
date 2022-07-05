using Microsoft.AspNetCore.Mvc;
using Cinema.Services;
using Cinema.Services.Dto;

namespace Cinema.API.Controllers
{
    [ApiController]
    [Route("Serial")]
    public class SerialController : ControllerBase
    {
        private readonly ISerialService _service;
        public SerialController(ISerialService service)
        {
            _service = service;
        }
        [HttpGet]
        public Task<List<SerialDto>> Get()
        {
            return _service.GetSerials();
        }

        [HttpGet("{id:long}")]
        public Task<SerialDto> GetById(long id)
        {
            return _service.GetSerialById(id);
        }

        [HttpPost]
        public Task<long> Create([FromBody] SerialDto dto)
        {
            return _service.Create(dto);
        }

        [HttpPut]
        public Task Update([FromBody] SerialDto dto)
        {
            return _service.UpdateSerial(dto);
        }

        [HttpDelete("{id:long}")]
        public Task Delete(long id)
        {
            return _service.DeleteSerial(id);
        }
    }
}
