﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahiber.Models
{
    public class Violation
    {
        public long Id { get; set; }
        public long RuleId { get; set; }
        public long MemberId { get; set; }
        public string Description { get; set; }

        [ForeignKey("MemberId")]
        public Member Memember { get; set; }

        [ForeignKey("RuleId")]
        public Rule Rule { get; set; }
    }
}
