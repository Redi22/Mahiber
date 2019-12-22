using Mahiber.Models;
using Mahiber.notifications;
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
    /// Interaction logic for MemberRoleRegistration.xaml
    /// </summary>
    public partial class MemberRoleRegistration : UserControl
    {
        private MahiberDbContext _context = null;
        UserAccount admins = new UserAccount();
        long AccountRole;
        UserAccount Account;
        public MemberRoleRegistration()
        {
            InitializeComponent();
            _context = new MahiberDbContext();

        }
        public void CheckAdmin(UserAccount Account)
        {
            this.Account = Account;
            this.AccountRole = Account.RoleId;
        }
        private void RoleId_Loaded(object sender, RoutedEventArgs e)
        {
            var gr = sender as ComboBox;
            gr.ItemsSource = _context.Roles.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (AccountRole == 1)
            {
                admins.RoleId = Convert.ToInt64(RoleId.SelectedIndex);
                admins.Username = Username.Text.Trim();
                admins.Password = PasswordBox.Password;
                
                _context.UserAccounts.Add(admins);
                _context.SaveChanges();
                SuccessMessage Sm = new SuccessMessage();
                Sm.MessageText.Text = "Admin Added Successfully";
                Sm.Show();

            }
            else
            {
                ErrorMessage Sm = new ErrorMessage();
                Sm.MessageText.Text = "Access Denied";
                Sm.Show();
            }


        }
    }
}
