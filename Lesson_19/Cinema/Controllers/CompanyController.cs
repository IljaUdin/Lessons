using Microsoft.AspNetCore.Mvc;
using Cinema.Services;
using Cinema.Services.Dto;

namespace Cinema.API.Controllers
{
    [ApiController]
    [Route("Company")]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _service;
        public CompanyController(ICompanyService service)
        {
            _service = service;
        }
        [HttpGet]
        public Task<List<CompanyDto>> Get()
        {
            return _service.GetCompanies();
        }

        [HttpGet("{id:long}")]
        public Task<CompanyDto> GetById(long id)
        {
            return _service.GetCompanyById(id);
        }

        [HttpPost]
        public Task<long> Create([FromBody] CompanyDto dto)
        {
            return _service.Create(dto);
        }

        [HttpPut]
        public Task Update([FromBody] CompanyDto dto)
        {
            return _service.UpdateCompany(dto);
        }

        [HttpDelete("{id:long}")]
        public Task Delete(long id)
        {
            return _service.DeleteCompany(id);
        }
    }
}
