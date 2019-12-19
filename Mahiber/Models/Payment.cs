using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahiber.Models
{
   public class Payment
    {
        public long Id { get; set; }
        public long MemberId { get; set; }
        public double Amount { get; set; }
        public String Type { get; set; }
        public DateTime PaidDate { get; set; }


        [ForeignKey("MemberId")]
        public Member Member { get; set; }
    }
}
