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

namespace Mahiber.forms.Report
{
    /// <summary>
    /// Interaction logic for ReportMain.xaml
    /// </summary>
    public partial class ReportMain : UserControl
    {
        private MahiberDbContext _context = null;
        List<MahiberEvent> edirEvents = null;
        List<MahiberEvent> allEdirEvents = null;
        List<Member> members    = null;
        List<Member> allMembers = null;
        List<Rule> rules    = null;
        List<Rule> allRules = null;
        List<Payment>   pays    = null;
        List<Payment>  allPays  = null;
        DateTime dt;
        public ReportMain()
        {
            InitializeComponent();
            _context = new MahiberDbContext();
            dt = DateTime.Now.Date;
            edirEvents = new List<MahiberEvent>();
            members = new List<Member>();
            allMembers = new List<Member>();
            rules = new List<Rule>();
            allRules = new List<Rule>();
            pays = new List<Payment>();
            allPays = new List<Payment>();
            String month= DateTime.Now.ToString("MMMM");
            head.Header = "report for the month " + month;
            container.Text = "This is a report about basic activities of this edir for this month.";
            event_viewer();
            mem_viewer();
            pay_viewer();
            rule_viewer();

        }

        private void event_viewer()
        {
            allEdirEvents = _context.MahiberEvents.ToList();
            foreach (MahiberEvent ev in allEdirEvents)
            {
                if((ev.Date - dt).TotalDays <= 30)
                {
                    edirEvents.Add(ev);
                    grid_event.Children.Clear();
                }
            }

            foreach(MahiberEvent e in edirEvents)
            {
                long attendees = _context.Attendances.Where(a => a.EventId == e.Id).Count();
                DescriptionCard dc = new DescriptionCard();
                dc.title.Content = e.Name;
                dc.descriptions.Text = "On " + e.Date + " the event took place." + e.Description + ". The number of attendees was " + attendees + ". The event took place at " + e.Place + ". ";
                grid_event.Children.Add(dc);
            }
        }
        private void mem_viewer()
        {
            allMembers = _context.Members.ToList();
            foreach (Member ev in allMembers)
            {
                if ((ev.RegisteredDate - dt).TotalDays <= 30)
                {
                    members.Add(ev);
                    grid_mem.Children.Clear();
                }
            }

            foreach(Member e in members)
            {
                DescriptionCard dc = new DescriptionCard();
                dc.title.Content = e.FirstName;
                dc.descriptions.Text = "On " + e.RegisteredDate + " the event took place." + ". The number of attendees was " +  ". The event took place at "  + ". ";
                grid_mem.Children.Add(dc);
            }
        }

       
        private void rule_viewer()
        {
            allRules = _context.Rules.ToList();
            foreach (Rule ev in allRules)
            {
                if ((ev.RegisteredDate - dt).TotalDays <= 30)
                {
                    rules.Add(ev);
                    grid_rule.Children.Clear();
                }
            }
        
            foreach (Rule e in rules)
            {
                DescriptionCard dc = new DescriptionCard();
                dc.title.Content = e.Name;
                dc.descriptions.Text = "On " + e.RegisteredDate + " the event took place." + ". The number of attendees was " + ". The event took place at " + ". ";
                grid_rule.Children.Add(dc);
            }
        }
        private void pay_viewer()
        {
            allPays = _context.Payments.ToList();
            foreach (Payment ev in allPays)
            {
                if ((ev.PaidDate - dt).TotalDays <= 30)
                {
                    pays.Add(ev);
                    grid_pay.Children.Clear();
                }
            }
        
            foreach (Payment e in pays)
            {
                DescriptionCard dc = new DescriptionCard();
                dc.title.Content = e.Type;
                dc.descriptions.Text = "On " + e.PaidDate + " the event took place." + ". The number of attendees was " + ". The event took place at " + ". ";
                grid_pay.Children.Add(dc);
            }
        }

    }
}
