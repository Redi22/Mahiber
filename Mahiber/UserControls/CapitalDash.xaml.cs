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
    /// Interaction logic for CapitalDash.xaml
    /// </summary>
    public partial class CapitalDash : UserControl
    {
        private MahiberDbContext _context = null;
        public CapitalDash()
        {
            InitializeComponent();
            _context = new MahiberDbContext();
            capital.Text = _context.Abouts.FirstOrDefault().Capital.ToString();
        }

    }
}
