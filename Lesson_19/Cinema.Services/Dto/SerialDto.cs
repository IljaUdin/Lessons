using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Services.Dto
{
    public class SerialDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public long CountryId { get; set; }
    }
}
