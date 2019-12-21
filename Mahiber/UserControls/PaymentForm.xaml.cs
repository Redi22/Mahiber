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
    /// Interaction logic for PaymentForm.xaml
    /// </summary>
    public partial class PaymentForm : UserControl
    {
        private MahiberDbContext _context = null;
        double Amount = 40;
        int index = 0;
        Payment pay = null;
        DateTime paidDate = DateTime.Now.Date;
        List<Member> members = null;
        About mahiber;
        public PaymentForm()
        {
            InitializeComponent();
            _context = new MahiberDbContext();
            pay = new Payment();
            members = _context.Members.ToList();
            mahiber = _context.Abouts.FirstOrDefault();

        }
       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Member member in members)
            {
                member.AttendStatus = false;
                _context.Entry(member).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
            }
        }
        private void MemberId_Loaded(object sender, RoutedEventArgs e)
        {
            var gr = sender as ComboBox;
            members = _context.Members.ToList();
            gr.ItemsSource = members;
        }
        private void FullPay_Click(object sender, RoutedEventArgs e)
        {
            Member mem = ((Member)MemberId.SelectedItem);
            if (mem != null)
            {
                double amount = mem.Debit;
                mahiber.Capital += mem.Debit;
                mem.Debit = 0;
                _context.Entry(mem).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
                Payment pay = new Payment();
                pay.PaidDate = DateTime.Now.Date;
                pay.Type = "Debit Cover";
                pay.MemberId = mem.Id;
                pay.Amount = amount;
                _context.Payments.Add(pay);
                _context.SaveChanges();
            }

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int checkBoxColum = 4;
            List<Member> selectedMembers = new List<Member>();
            List<Attendance> pays = new List<Attendance>();
            for (int i = 0; i < MemberDataGrid.Items.Count - 1; i++)
            {
                var item = MemberDataGrid.Items[i];
                var item2 = MemberDataGrid.Items[i];
                var payStatusCheckbox = MemberDataGrid.Columns[checkBoxColum].GetCellContent(item) as CheckBox;
                var stg = MemberDataGrid.Columns[0].GetCellContent(item) as TextBlock;
                long Id =Convert.ToInt64(stg.Text);

                if ((bool)payStatusCheckbox.IsChecked)
                {
                    Member member = _context.Members.FirstOrDefault(m => m.Id == Id);
                    member.PayStatus = true;
                    pay.MemberId = member.Id;
                    pay.PaidDate = paidDate;
                    pay.Amount = mahiber.MonthlyPayment;

                    _context.Payments.Add(pay);
                    _context.Entry(member).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();


                }
            }
            foreach (Member member in members)
            {

                if (member.AttendStatus == false)
                {
                    member.Debit += mahiber.MonthlyPayment;
                    _context.Entry(member).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();
                }
            }

        }

        private void MemberDataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            MemberDataGrid.ItemsSource = members;
        }
    }
}
    

