using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.Services.Dto;

namespace Cinema.Services
{
    public interface ICompanyService
    {
        public Task<List<CompanyDto>> GetCompanies();
        public Task<CompanyDto> GetCompanyById(long id);
        public Task<long> Create(CompanyDto dto);
        public Task UpdateCompany(CompanyDto dto);
        public Task DeleteCompany(long id);
    }
}
