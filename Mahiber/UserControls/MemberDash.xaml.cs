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
    /// Interaction logic for MemberDash.xaml
    /// </summary>
    public partial class MemberDash : UserControl
    {
        private MahiberDbContext _context = null;
        public MemberDash()
        {
            InitializeComponent();
            _context = new MahiberDbContext();
            member.Text = _context.Violations.Count().ToString();
        }
    }
}
