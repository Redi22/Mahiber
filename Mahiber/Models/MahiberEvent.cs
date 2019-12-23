using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahiber.Models
{
    public class MahiberEvent
    {
        public MahiberEvent()
        {
            Date =
            Time = DateTime.Now;
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Place { get; set; }
        public double Fin { get; set; }

    }
}
