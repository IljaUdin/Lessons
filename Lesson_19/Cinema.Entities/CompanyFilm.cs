using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entities
{
    public class CompanyFilm
    {
        public long CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public long FilmId { get; set; }
        public virtual Film Film { get; set; }
    }
}
