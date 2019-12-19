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
    /// Interaction logic for PastEvent.xaml
    /// </summary>
    public partial class PastEvent : UserControl
    {
        private MahiberDbContext _context = null;
        MahiberEvent past = null;
        public PastEvent()
        {
            InitializeComponent();
            _context = new MahiberDbContext();
            past = _context.MahiberEvents.FirstOrDefault();

            Check_view();
        }
        public void Check_view()
        {
            if (past != null)
            {
                eventName.Text = past.Name.ToString();
                eventTime.Text = past.Date.ToString();
                eventDescription.Text = past.Description.ToString();
            }
            else
            {
                eventDescription.Text = past.Description.ToString();

            }

        }
    }
}
