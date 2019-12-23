using Mahiber;
using Mahiber.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Edir.notification
{
    /// <summary>
    /// Interaction logic for MainNotificationPage.xaml
    /// </summary>
    public partial class MainNotificationPage : UserControl
    {
        MahiberDbContext _context = null;
        List<Member> debitedMembers = null;
        List<Member> members = null;
        List<Member> violators = null;
        long memberId;

        public MainNotificationPage()
        {
            InitializeComponent();
            _context = new MahiberDbContext();
            violators = new List<Member>();
            members = _context.Members.ToList();

            debitedMembers = _context.Members.Where(m => m.Debit >= 400).ToList();

            foreach(Member member in members)
            {
                if (_context.Violations.Where(v => v.MemberId == member.Id).Count() >= 3)
                {
                    violators.Add(member);
                }

            }

            DebitMemberView.ItemsSource = debitedMembers;
            RuleViolView.ItemsSource = violators;

        }
    }
}
