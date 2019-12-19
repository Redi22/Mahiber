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
    /// Interaction logic for AttendanceForm.xaml
    /// </summary>
    public partial class AttendanceForm : UserControl
    {
        private MahiberDbContext _context = null;
        MahiberEvent eve;
        List<Member> members;
        DataGrid EventGrid;
        Attendance Attendance = new Attendance();
        public AttendanceForm()
        {
            InitializeComponent();
            _context = new MahiberDbContext();
            members = _context.Members.ToList();
            MemberDataGrid.ItemsSource = members;

        }
        public void GridInitializer(DataGrid EventGrid)
        {
            this.EventGrid = EventGrid;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach(Member member in members)
            {
                member.AttendStatus = false;
                _context.Entry(member).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int checkBoxColum = 4;
            eve = ((MahiberEvent)EventGrid.SelectedItem);
            List<Member> selectedMembers = new List<Member>();
            List<Attendance> pays = new List<Attendance>();
            for (int i = 0; i < MemberDataGrid.Items.Count-1 ; i++)
                {
                    var item = MemberDataGrid.Items[i];
                    var payStatusCheckbox = MemberDataGrid.Columns[checkBoxColum].GetCellContent(item) as CheckBox;
                    var stg =MemberDataGrid.Columns[0].GetCellContent(item) as TextBlock;
                    long Id = 4;
                    if ((bool)payStatusCheckbox.IsChecked)
                        {
                            Member member = _context.Members.FirstOrDefault(m => m.Id == Id);
                    member.AttendStatus = true;
                            Attendance.MemberId = member.Id;
                            Attendance.EventId = eve.Id;
                            _context.Attendances.Add(Attendance);
                            _context.Entry(member).State = System.Data.Entity.EntityState.Modified;
                            _context.SaveChanges();

                    
                        }
                }
            foreach(Member member in members)
            {
                
                if(member.AttendStatus == false)
                {
                    member.Debit += eve.Fin;
                    _context.Entry(member).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();
                }
            }
            
        }
    }
}
