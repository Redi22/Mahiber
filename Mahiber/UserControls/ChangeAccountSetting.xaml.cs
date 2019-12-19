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
    /// Interaction logic for ChangeAccountSetting.xaml
    /// </summary>
    public partial class ChangeAccountSetting : UserControl
    {
        private MahiberDbContext _context = null;
        UserAccount User = new UserAccount();
        UserAccount Account;
        long AccountRole;
        public ChangeAccountSetting()
        {
            InitializeComponent();
            _context = new MahiberDbContext();
        }
        public void CheckAdmin(UserAccount Account)
        {
            this.Account = Account;
            this.AccountRole = Account.RoleId;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Account.Password == PasswordBox.ToString())
            {
                if (NewPass.ToString() == Confirm.ToString())
                {
                    Account.Password = NewPass.ToString();
                    _context.Entry(Account).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();
                    SuccessMessage sm = new SuccessMessage();
                    sm.MessageText.Text = "Password Changed";
                    sm.Show();
                }
            }

        }
    }
}
