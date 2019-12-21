using Edir.forms.SignUpForms;
using Mahiber.Models;
using Mahiber.SignUpForms;
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
    /// Interaction logic for SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        private MahiberDbContext _context = null;
        int index;
        String description;
        String name;
        About mahiber;
        ThirdPage thirdPage;
        FinalPage finalPage;
        UserAccount user;

        public SignUpWindow()
        {
            InitializeComponent();
            _context = new MahiberDbContext();
            index = 0;
            mahiber = new About();


        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (index == 0)
            {
                name = MahiberName.Text.ToString();
                description = Description.Text.ToString();
                thirdPage = new ThirdPage();
                MainContent.Children.Clear();
                MainContent.Children.Add(thirdPage);
                thirdPage.Initialize(name, description);
                index++;
            }
            else if(index == 1)
            {
                mahiber = thirdPage.returner();
                _context.Abouts.Add(mahiber);
                _context.SaveChanges();
                finalPage = new FinalPage();
                MainContent.Children.Clear();
                MainContent.Children.Add(finalPage);
                cont_btn.Text = "Create Super Admin";
                index++;
            }
            else if(index == 3)
            {
                user = new UserAccount();
                user.Username = finalPage.username.Text.ToString();
                user.Password = finalPage.password.Password;
                user.RoleId = 1;
                _context.UserAccounts.Add(user);
                _context.SaveChanges();

            }
        }

        private void withpay_Checked(object sender, RoutedEventArgs e)
        {
            ContinueBtn.IsEnabled = true;
        }

        private void withpay_Unchecked(object sender, RoutedEventArgs e)
        {
            ContinueBtn.IsEnabled = false;

        }
    }
}

