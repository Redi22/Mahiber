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
using Mahiber.notifications;

namespace Mahiber.UserControls
{
    /// <summary>
    /// Interaction logic for EventForm.xaml
    /// </summary>
    public partial class EventForm : UserControl
    {
        private MahiberDbContext _context = null;
        List<MahiberEvent> allEvents;
        List<Member> members;
        public EventForm()
        {
            InitializeComponent();
            _context = new MahiberDbContext();
            allEvents = _context.MahiberEvents.ToList();
            InitializeGrid();


        }
        public void InitializeGrid()
        {
            EventGrid.ItemsSource = allEvents;
            
        }
        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MahiberEvent mahiberEvent = new MahiberEvent();
                mahiberEvent.Name = EventName.Text.Trim();
                mahiberEvent.Date = Convert.ToDateTime(EventDate.Text);
                mahiberEvent.Place = EventPlace.Text.Trim();
                mahiberEvent.Description = Description.Text.Trim();
                mahiberEvent.Time = Convert.ToDateTime(EventTime.Text);
                mahiberEvent.Fin = Convert.ToDouble(EventFin.Text);

                _context.MahiberEvents.Add(mahiberEvent);
                _context.SaveChanges();


            }
             catch (Exception)
            {

            }
            
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            MahiberEvent selected = ((MahiberEvent)EventGrid.SelectedItem);
            selected.Name = EventName.Text.Trim();
            selected.Date = Convert.ToDateTime(EventDate.Text);
            selected.Time = Convert.ToDateTime(EventTime.Text);
            selected.Place = EventPlace.Text.Trim();
            selected.Description = Description.Text.Trim();
            selected.Fin = Convert.ToDouble(EventFin.Text);

                _context.Entry(selected).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            }
            catch (Exception)
            {

            }

        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MahiberEvent selected = ((MahiberEvent)EventGrid.SelectedItem);
                DeleteConfirmation Confirmation = new DeleteConfirmation();
                Confirmation.assigner(selected);
                Confirmation.Show();

            }
            catch (Exception)
            {

            }
        }

        private void Search_KeyUp(object sender, KeyEventArgs e)
        {
            List<MahiberEvent> searched = new List<MahiberEvent>();
            foreach(MahiberEvent mahiberEvent in allEvents)
            {
                if (mahiberEvent.Name.ToLower().Contains(Search.Text.ToString().ToLower()))
                {
                    searched.Add(mahiberEvent);
                }
            }
            EventGrid.ItemsSource = searched;
        }

        private void EventGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                MahiberEvent selected = ((MahiberEvent)EventGrid.SelectedItem);
                EventName.Text = selected.Name;
                EventPlace.Text = selected.Place;
                EventFin.Text = selected.Fin.ToString();
                Description.Text = selected.Description;
                EventDate.Text = selected.Date.Date.ToString();
                EventTime.Text = selected.Time.ToShortTimeString(); 

            }
            catch (Exception)
            {

            }

        }

       

        private void Attendance_Click(object sender, RoutedEventArgs e)
        {
            AttendanceForm.Children.Clear();
            AttendanceForm attendanceForm = new AttendanceForm();
            attendanceForm.GridInitializer(EventGrid);
            AttendanceForm.Children.Add(attendanceForm);
        }

        private void refreshBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Review_Click(object sender, RoutedEventArgs e)
        {


        }
    }
}
