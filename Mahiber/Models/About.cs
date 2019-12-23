using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahiber.Models
{
    public class About
    {
        public About()
        {
            PayDay = DateTime.Now;
            CreationDate = DateTime.Now;
        }
        public long Id { get; set; }
        public string EdirName { get; set; }
        public double Capital { get; set; }
        public string Description { get; set; }
        public double MonthlyPayment { get; set; }
        public double PaymentFin { get; set; }
        public double EventFin { get; set; }
        public double FirstFin { get; set; }
        public double SecondFin { get; set; }
        public double LastFin { get; set; }
        public bool WithPay { get; set; }
        public DateTime PayDay       { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
