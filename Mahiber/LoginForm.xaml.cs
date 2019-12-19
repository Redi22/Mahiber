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
using System.Windows.Shapes;

namespace Mahiber
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        private MahiberDbContext _context = null;
        bool Logged;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            List<UserAccount> userAccounts = _context.UserAccounts.ToList();
            UserAccount user = new UserAccount();
            user.Username = Username.Text.Trim();
            user.Password = Password.ToString();

            foreach (UserAccount u in userAccounts)
            {
                if (user.Username == u.Username && user.Password == u.Password)
                {
                    MainWindow main = new MainWindow();
                    main.Show();
                    main.CheckAdmin(u);
                    Logged = true;
                }
            }
            if (!Logged)
            {
                ErrorMessage er = new ErrorMessage();
                er.MessageText.Text = "Wrong Password";
                er.Show();
            }


        }
    }
}
