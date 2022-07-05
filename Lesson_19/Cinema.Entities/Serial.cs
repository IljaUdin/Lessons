using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entities
{
    public class Serial
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public long CountryId { get; set; }
        public virtual Country Country { get; set; }
        public ICollection<CompanyFilm> CompanyFilms { get; set; }
    }
}
