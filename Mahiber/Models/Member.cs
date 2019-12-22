using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahiber.Models
{
    public class Member
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SpouseName { get; set; }
        public string Gender { get; set; }
        public bool MariageStatus { get; set; }
        public string SubCity { get; set; }
        public long Woreda { get; set; }
        public long Kebele { get; set; }
        public long PhoneNumber { get; set; }
        public string HouseNummber { get; set; }
        public DateTime RegisteredDate { get; set; }
        public bool PayStatus { get; set; }
        public bool AttendStatus { get; set; }
        public double Debit { get; set; }

    }
}
