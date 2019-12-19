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
using System.Windows.Shapes;

namespace Mahiber.notifications
{
    /// <summary>
    /// Interaction logic for DeleteConfirmation.xaml
    /// </summary>
    public partial class DeleteConfirmation : Window
    {
        private MahiberDbContext _context = null;

        public DeleteConfirmation()
        {
            InitializeComponent();
            _context = new MahiberDbContext();
        }
        object Selected;
        public void assigner(object passed)
        {
            this.Selected = passed;
        }
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {

            _context.Entry(Selected).State = System.Data.Entity.EntityState.Deleted;
            _context.SaveChanges();
            SuccessMessage sm = new SuccessMessage();
            sm.MessageText.Text = "Deleted Successfully";
            this.Hide();
            sm.Show();

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
   
    }
}
