using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahiber.Models
{
    public class Rule
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double FirstFin { get; set; }
        public double SecondFin { get; set; }
        public double LastFin { get; set; }
        public DateTime RegisteredDate { get; set; }

        public ICollection<Violation> Violations { get; set; }

    }
}
