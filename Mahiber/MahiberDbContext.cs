using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mahiber.Models;


namespace Mahiber
{
    public class MahiberDbContext:DbContext
    {
        public MahiberDbContext() : base("mahiberDbConnection")
        {

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<MahiberEvent> MahiberEvents { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<Violation> Violations { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
