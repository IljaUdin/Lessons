using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.Services.Dto;

namespace Cinema.Services
{
    public interface ICountryService
    {
        public Task<List<CountryDto>> GetCountries();
        public Task<CountryDto> GetCountryById(long id);
        public Task<long> Create(CountryDto dto);
        public Task UpdateCountry(CountryDto dto);
        public Task DeleteCountry(long id);
    }
}
