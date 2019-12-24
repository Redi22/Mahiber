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
    /// Interaction logic for MemberForm.xaml
    /// </summary>
    public partial class MemberForm : UserControl
    {
        private MahiberDbContext _context = null;
        Member member = null;
        List<Attendance> attendances;
        List<Member> allMembers;
        long SelectedSubcity;
        private List<Member> allMember;

        public MemberForm()
        {
            InitializeComponent();
            _context = new MahiberDbContext();
            member = new Member();
            allMembers = _context.Members.ToList();
            MemGrid.ItemsSource = allMembers;


        }
       
       
        private void MarriageStat_Checked(object sender, RoutedEventArgs e)
        {
            MemSpouseName.IsEnabled = true;
        }

        private void MarriageStat_Unchecked(object sender, RoutedEventArgs e)
        {
            MemSpouseName.IsEnabled = false;
        }

        private void MemGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            member = ((Member)MemGrid.SelectedItem);
            try
            {
            MemName.Text = member.FirstName;
            MemLastName.Text = member.LastName;
            MemSpouseName.Text = member.SpouseName;
            if(member.Gender == "female")
            {
                GenderBtn.IsChecked = false;
            }else {
                GenderBtn.IsChecked = true;
            }
            if (member.MariageStatus == false)
            {
                MarriageStat.IsChecked = false;
            }else {
                    MarriageStat.IsChecked = true;
            }
                if (member.SubCity == "Arada")
                {
                    Subcity.SelectedIndex = 0;
                }
                else if (member.SubCity == "Akaki / Kality")
                {
                    Subcity.SelectedIndex = 1;
                }
                else if (member.SubCity == "Bole")
                {
                    Subcity.SelectedIndex = 2;
                }
                else if (member.SubCity == "Kolfe Keraniyo")
                {
                    Subcity.SelectedIndex = 3;
                }
                else if (member.SubCity == "Yeka")
                {
                    Subcity.SelectedIndex = 4;
                }
                else if (member.SubCity == "Gulele")
                {
                    Subcity.SelectedIndex = 5;
                }
                else if (member.SubCity == "Ledeta")
                {
                    Subcity.SelectedIndex = 6;
                }
                else if (member.SubCity == "Nefas Silk")
                {
                    Subcity.SelectedIndex = 7;
                }
                else if (member.SubCity == "Kirkos")
                {
                    Subcity.SelectedIndex = 8;
                }
                else if (member.SubCity == "Addis Ketema")
                {
                    Subcity.SelectedIndex = 9;
                }
                Woreda.Text = member.Woreda.ToString();
                Kebele.Text = member.Kebele.ToString();
                Phone.Text = member.PhoneNumber.ToString();
                HouseNum.Text = member.HouseNummber;
                ViolationsView.ItemsSource = _context.Violations.Where(v => v.MemberId == member.Id).ToList();
                attendances = _context.Attendances.Where(a => a.MemberId == member.Id).ToList();
                if(attendances != null)
                    AttebdanceView.ItemsSource = attendances;
            }
            catch (Exception)
            {

               
            }


        }


        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                member = ((Member)MemGrid.SelectedItem);
                DeleteConfirmation Confirmation = new DeleteConfirmation();
                Confirmation.assigner(member);
                Confirmation.Show();


            }
            catch (Exception)
            {

                
            }
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            member = ((Member)MemGrid.SelectedItem);
            try
            {
                member.FirstName = MemName.Text.Trim();
                member.LastName = MemLastName.Text.Trim();
                member.PhoneNumber = Convert.ToInt64(Phone.Text);
                member.Kebele = Convert.ToInt64(Kebele.Text);
                member.Woreda = Convert.ToInt64(Woreda.Text);
                if (MarriageStat.IsChecked.GetValueOrDefault())
                {
                    member.SpouseName = MemSpouseName.Text.Trim();
                    member.MariageStatus = true;
                }
                else { member.MariageStatus = false; }
                if (GenderBtn.IsChecked.GetValueOrDefault())
                {
                    member.Gender = "male";
                }
                else
                {
                    member.Gender = "female";
                }
                SelectedSubcity = Subcity.SelectedIndex;

                if (SelectedSubcity == 0)
                {
                    member.SubCity = "Arada";
                }
                else if (SelectedSubcity == 1)
                {
                    member.SubCity = "Akaki/Kality";
                }
                else if (SelectedSubcity == 2)
                {
                    member.SubCity = "Bole";
                }
                else if (SelectedSubcity == 3)
                {
                    member.SubCity = "Kolfe Keraniyo";
                }
                else if (SelectedSubcity == 4)
                {
                    member.SubCity = "Yeka";
                }
                else if (SelectedSubcity == 5)
                {
                    member.SubCity = "Gulele";
                }
                else if (SelectedSubcity == 6)
                {
                    member.SubCity = "Ledeta";
                }
                else if (SelectedSubcity == 7)
                {
                    member.SubCity = "Nefas Silk";
                }
                else if (SelectedSubcity == 8)
                {
                    member.SubCity = "Kirkos";
                }
                else if (SelectedSubcity == 9)
                {
                    member.SubCity = "Addis Ketema";
                }
                member.Debit = 0;
                member.HouseNummber = HouseNum.Text.Trim();
                _context.Entry(member).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {

            }
          

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                member.FirstName = MemName.Text.Trim();
                member.LastName = MemLastName.Text.Trim();
                member.PhoneNumber =Convert.ToInt64( Phone.Text);
                member.Kebele =Convert.ToInt64( Kebele.Text);
                member.Woreda =Convert.ToInt64( Woreda.Text);
                if (MarriageStat.IsChecked.GetValueOrDefault())
                {
                    member.SpouseName = MemSpouseName.Text.Trim();
                        member.MariageStatus = true;
                }
                else { member.MariageStatus = false; }
                if (GenderBtn.IsChecked.GetValueOrDefault())
                {
                    member.Gender = "male";
                }
                else
                {
                  member.Gender = "female";
                }
                SelectedSubcity = Subcity.SelectedIndex;

                if (SelectedSubcity == 0)
                {
                    member.SubCity = "Arada";
                }
                else if (SelectedSubcity == 1)
                {
                    member.SubCity = "Akaki/Kality";
                }
                else if (SelectedSubcity == 2)
                {
                    member.SubCity = "Bole";
                }
                else if (SelectedSubcity == 3)
                {
                    member.SubCity = "Kolfe Keraniyo";
                }
                else if (SelectedSubcity == 4)
                {
                    member.SubCity = "Yeka";
                }
                else if (SelectedSubcity == 5)
                {
                    member.SubCity = "Gulele";
                }
                else if (SelectedSubcity == 6)
                {
                    member.SubCity = "Ledeta";
                }
                else if (SelectedSubcity == 7)
                {
                    member.SubCity = "Nefas Silk";
                }
                else if (SelectedSubcity == 8)
                {
                    member.SubCity = "Kirkos";
                }
                else if (SelectedSubcity == 9)
                {
                    member.SubCity = "Addis Ketema";
                }
                member.Debit = 0;
                member.HouseNummber = HouseNum.Text.Trim();

                _context.Members.Add(member);
                _context.SaveChanges();
            }
            catch (Exception)
            {


            }
        }

        private void Search_KeyUp(object sender, KeyEventArgs e)
        {
            List<Member> searched = new List<Member>();
            foreach(Member member in allMembers)
            {
                if (member.FirstName.ToLower().Contains(Search.Text.ToLower()))
                {
                    searched.Add(member);
                }
            }
            MemGrid.ItemsSource = searched;
        }

        private void refreshBtn_Click(object sender, RoutedEventArgs e)
        {
            allMember = _context.Members.ToList();
            MemGrid.ItemsSource = allMember;
            ViolationsView.ItemsSource = _context.Violations.Where(v => v.MemberId == member.Id).ToList();
            attendances = _context.Attendances.Where(a => a.MemberId == member.Id).ToList();
            if (attendances != null)
                AttebdanceView.ItemsSource = attendances;
        }
    }
}
