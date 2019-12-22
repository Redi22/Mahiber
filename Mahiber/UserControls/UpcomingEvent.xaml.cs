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

namespace Mahiber.UserControls
{
    /// <summary>
    /// Interaction logic for UpcomingEvent.xaml
    /// </summary>
    public partial class UpcomingEvent : UserControl
    {
        private MahiberDbContext _context = null;
        MahiberEvent upcoming = null;
        public UpcomingEvent()
        {
            InitializeComponent();
            _context = new MahiberDbContext();
            upcoming = _context.MahiberEvents.FirstOrDefault();

            Check_view();
        }
        public void Check_view()
        {
            if (upcoming != null)
            {
                eventName.Text = upcoming.Name.ToString();
                eventTime.Text = upcoming.Date.ToString();
                eventDescription.Text = upcoming.Description.ToString();
            }
            else
            {
                eventDescription.Text = "There are no upcomming event.";

            }

        }
    }
}
