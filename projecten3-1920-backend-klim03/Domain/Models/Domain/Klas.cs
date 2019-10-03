using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class Klas
    {
        public long KlasId { get; set; }

        public string Naam { get; set; }

        public long SchoolId { get; set; }
        public School School { get; set; }

        public ICollection<Leerling> Leerlingen { get; set; } = new List<Leerling>();

        public ICollection<Project> Projecten { get; set; } = new List<Project>();
    }
}
