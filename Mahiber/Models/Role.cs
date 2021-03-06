﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahiber.Models
{
    public class Role
    {
        public Role()
        {
            RoleCreationDate = DateTime.Now;
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool EventPrivilage { get; set; }
        public bool MemberPrivilage { get; set; }
        public bool PaymentPrivilage { get; set; }
        public bool RulePrivilage { get; set; }
        public bool SuperAdminPrivilage { get; set; }
        public DateTime RoleCreationDate { get; set; }

    }
}
