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

namespace Mahiber.forms.SignUpForms
{
    /// <summary>
    /// Interaction logic for ThirdPage.xaml
    /// </summary>
    public partial class ThirdPage : UserControl
    {
       
        About mahiber;
        Role role;
        private MahiberDbContext _context = null;
        public ThirdPage()
        {
            InitializeComponent();
            mahiber = new About();
            _context = new MahiberDbContext();
            role = new Role();
        }

        public void Initialize(String name , String description)
        {
            mahiber.EdirName = name;
            mahiber.Description = description;

           
        }
        public void returner()
        {
            mahiber.EventFin = Convert.ToInt64(EventFin.Text);
            mahiber.FirstFin = Convert.ToInt64(FirstFin.Text);
            mahiber.SecondFin = Convert.ToInt64(SecondFin.Text);
            mahiber.LastFin = Convert.ToInt64(FinalFin.Text);
            mahiber.PaymentFin = Convert.ToInt64(PaymentFin.Text);
            mahiber.CreationDate = DateTime.Now.Date;
            _context.Abouts.Add(mahiber);
            _context.SaveChanges();

        }

        private void FinishBtn_Click(object sender, RoutedEventArgs e)
        {
            DateTime now = DateTime.Now.Date;
            role.Name = "Super Admin";
            role.Description = "this admin has all privilages and also must add new admins.";
            role.SuperAdminPrivilage = true;
            role.RoleCreationDate = now;
            _context.Roles.Add(role);
            _context.SaveChanges();

            role.Name = "Admin";
            role.Description = "this admin has all privilages except store privilages. There can be multiple admins but all will have equal privilages.";
            role.SuperAdminPrivilage =false;
            role.RulePrivilage = role.PaymentPrivilage = role.MemberPrivilage = role.EventPrivilage = true;
            role.RoleCreationDate = now;
            _context.Roles.Add(role);
            _context.SaveChanges();

           

        }
    }
}
