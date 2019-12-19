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
       
        public Settings()
        {
            InitializeComponent();
        }

        public void CheckAdmin(UserAccount Account)
        {
            this.AccountRole = Account.RoleId;
            this.Account = Account;
        }
        private void ListView_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            SettingGrid.Children.Clear();
            ChangeAccountSetting ch = new ChangeAccountSetting();
            SettingGrid.Children.Add(ch);
            ch.CheckAdmin(Account);
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
