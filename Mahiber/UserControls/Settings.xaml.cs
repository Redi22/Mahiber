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
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : UserControl
    {
        long AccountRole;
        UserAccount Account;
        Role role;
        private MahiberDbContext _context = null;
        public Settings()
        {
            InitializeComponent();
            _context = new MahiberDbContext();
            role = new Role();
        }

        public void CheckAdmin(UserAccount Account)
        {
            this.AccountRole = Account.RoleId;
            this.Account = Account;
        }
        private void CreateRoleBtn_Click(object sender, RoutedEventArgs e)
        {
            role.Name = RoleName.Text.Trim();
            role.Description = Description.Text.ToString();
            role.EventPrivilage = role.PaymentPrivilage = role.SuperAdminPrivilage =
            role.MemberPrivilage = false;
            if (MemberPrivilage.IsChecked.GetValueOrDefault())
            {
                role.MemberPrivilage = true;
            }
            if (EventPrivilage.IsChecked.GetValueOrDefault())
            {
                role.EventPrivilage = true;
            }
            if (PaymentPrivilage.IsChecked.GetValueOrDefault())
            {
                role.PaymentPrivilage = true;
            }
           
            role.RoleCreationDate = DateTime.Now.Date;
            _context.Roles.Add(role);
            _context.SaveChanges();

        }
        private void ListView_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            SettingGrid.Children.Clear();
            ChangeAccountSetting ch = new ChangeAccountSetting();
            ch.CheckAdmin(Account);
            SettingGrid.Children.Add(ch);
        }

        private void ListView_PreviewMouseDown_1(object sender, MouseButtonEventArgs e)
        {
            SettingGrid.Children.Clear();
            MemberRoleRegistration Form = new MemberRoleRegistration();
            SettingGrid.Children.Add(Form);
            Form.CheckAdmin(Account);
        }
    }
}
