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
using Mahiber.notifications;
using Mahiber.UserControls;
using Mahiber.Models;
namespace Mahiber
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MahiberDbContext _context = null;
        bool withPay;
        DateTime DateNow;
        About mahiber;
        public long AccountRole;
        UserAccount Account;
        public MainWindow()
        {
            InitializeComponent();
            _context = new MahiberDbContext();
            //Account.RoleId = 1;
            withPay = _context.Abouts.FirstOrDefault().WithPay;
            DateNow = DateTime.Now.Date;
            mahiber = _context.Abouts.FirstOrDefault();
            Dash_view();
        }
       
        public void CheckAdmin(UserAccount Account)
        {
            AccountRole = Account.RoleId;
            this.Account = Account;
        }
        public void Dash_view()
        {
            clear_all();
            dashbord1.Children.Add(new CapitalDash());
            dashbord2.Children.Add(new MemberDash());
            dashbord3.Children.Add(new ViolationDash());
            Upcoming.Children.Clear();
            Upcoming.Children.Add(new UpcomingEvent());
            Past.Children.Add(new PastEvent());
        }
        private void menuDrawerClose_Click(object sender, RoutedEventArgs e)
        {
            menuDrawerClose.Visibility = Visibility.Collapsed;
            menuDrawerOpen.Visibility = Visibility.Visible;
        }

        private void menuDrawerOpen_Click(object sender, RoutedEventArgs e)
        {
            menuDrawerClose.Visibility = Visibility.Visible;
            menuDrawerOpen.Visibility = Visibility.Collapsed;
        }

        private void notificationButton_Click(object sender, RoutedEventArgs e)
        {
            clear_all();
            //Pay LastPay = _context.Payments.LastOrDefault();
            //List<Pay> pays = _context.Payments.Where(p => p.PaymentCode == LastPay.PaymentCode).ToList();
           

        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {

            clear_all();
            Settings settings = new Settings();
            named.Children.Add(settings);

        }

        private void Members_clicked(object sender, MouseButtonEventArgs e)
        {

            if (AccountRole == 0)
            {
                clear_all();
                MemberForm Form = new  MemberForm();
                named.Children.Add(Form);
            }
            else
            {
                
            }


        }

        private void Event_clicked(object sender, MouseButtonEventArgs e)
        {
            if (AccountRole != 2)
            {

                clear_all();
                named.Children.Add(new EventForm());


            }
            else
            {
                //ErrorMessage er = new ErrorMessage();
                //er.MessageText.Text = "Access Denied";
                //er.Show();
            }
        }

        public void clear_all()
        {
            dashbord1.Children.Clear();
            dashbord2.Children.Clear();
            dashbord3.Children.Clear();
            Upcoming.Children.Clear();
            Past.Children.Clear();
            named.Children.Clear();
            //ProfileView.Children.Clear();
        }
        public void reset_color()
        {
            //brush.Color = ;
            //listViewItem.Background = brush;
        }

       
        private void Rules_clicked(object sender, MouseButtonEventArgs e)
        {
            if (AccountRole == 0)
            {

                clear_all();
                named.Children.Add(new RuleForm());
            }
            else
            {
            //    ErrorMessage er = new ErrorMessage();
            //    er.MessageText.Text = "Access Denied";
            //    er.Show();
            }
        }

        private void Home_clicked(object sender, MouseButtonEventArgs e)
        {

            clear_all();
            //reset_color();
            Dash_view();
        }

        private void Payment_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (true)
            {
                PaymentForm pm = new PaymentForm();
                TimeSpan timeSpan = mahiber.PayDay.Date - DateTime.Now.Date;

                if (timeSpan.TotalDays % 30 == 0)
                {
                    if (true)
                    {
                        clear_all();
                        named.Children.Add(pm);

                    }
                }
                else
                {
                    PayDateNotify pd = new PayDateNotify();
                    long daysLeft = mahiber.PayDay.Day - DateTime.Now.Day;

                    if (daysLeft < 0)
                    {
                        daysLeft += 30;
                    }
                    pd.DaysLeft.Text = daysLeft.ToString();

                    clear_all();
                    pm.PaymentMainGrid.Children.Clear();
                    pm.PaymentMainGrid.Children.Add(pd);
                    named.Children.Add(pm);


                }

            }
            else
            {
                ErrorMessage er = new ErrorMessage();
                er.MessageText.Text = "Access Denied";
                er.Show();
            }
        }

    

        private void ReportButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

