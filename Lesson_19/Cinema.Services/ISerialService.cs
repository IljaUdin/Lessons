using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.Services.Dto;

namespace Cinema.Services
{
    public interface ISerialService
    {
        public Task<List<SerialDto>> GetSerials();
        public Task<SerialDto> GetSerialById(long id);
        public Task<long> Create(SerialDto dto);
        public Task UpdateSerial(SerialDto dto);
        public Task DeleteSerial(long id);
    }
}
