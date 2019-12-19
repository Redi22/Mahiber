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
using Mahiber.Models;
using Mahiber.notifications;

namespace Mahiber.UserControls
{
    /// <summary>
    /// Interaction logic for RuleForm.xaml
    /// </summary>
    public partial class RuleForm : UserControl
    {
        private MahiberDbContext _context = null;
        List<Rule> allRules ;
        public List<Rule> RulesList { get; set; }
        Rule rule;
        About Mahiber;
        Violation violation = null;
        public RuleForm()
        {
            InitializeComponent();
            _context = new MahiberDbContext();
            rule = new Rule();
            allRules = _context.Rules.ToList();
            RulesGrid.ItemsSource = allRules;
            violation = new Violation();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Rule Selected = ((Rule)RulesGrid.SelectedItem);

                RuleName.Text = Selected.Name.ToString();
                Description.Text = Selected.Description.ToString();
                FirstFin.Text = Selected.FirstFin.ToString();
                SecondFin.Text = Selected.SecondFin.ToString();
                FinalFin.Text = Selected.LastFin.ToString();
                _context.Entry(Selected).State = System.Data.Entity.EntityState.Modified;
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
                rule.Name = RuleName.Text.Trim();
                rule.Description = Description.Text.Trim();
                rule.FirstFin = Convert.ToDouble(FirstFin.Text);
                rule.SecondFin = Convert.ToDouble(SecondFin.Text);
                rule.LastFin = Convert.ToDouble(FinalFin.Text);

                _context.Rules.Add(rule);
                _context.SaveChanges();
                ErrorMessage sm = new ErrorMessage();
                sm.MessageText.Text = "Registered Successfully";
                sm.Show();
            }
            catch (Exception)
            {

            }

        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Rule Selected = ((Rule)RulesGrid.SelectedItem);
                DeleteConfirmation Confirmation = new DeleteConfirmation();
                Confirmation.assigner(Selected);
                Confirmation.Show();

            }
            catch (Exception)
            {

            }
        }

        private void RulesGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Rule Selected = ((Rule)RulesGrid.SelectedItem);

            if (Selected != null)
            {
                RuleName.Text = Selected.Name.ToString();
                Description.Text = Selected.Description.ToString();
                FirstFin.Text = Selected.FirstFin.ToString();
                SecondFin.Text = Selected.SecondFin.ToString();
                FinalFin.Text = Selected.LastFin.ToString();

            }
        }

        private void ViolatedRuleId_Loaded(object sender, RoutedEventArgs e)
        {
            var Rules = _context.Rules.ToList();
            RulesList = Rules;
            ViolatedRuleId.ItemsSource = RulesList;
        }

        private void ReportBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Mahiber = _context.Abouts.FirstOrDefault();
                long SelMemId = Convert.ToInt64(MemId.Text);
                long SelRuleId = 0;
                double First = Mahiber.FirstFin;
                double Second = Mahiber.SecondFin;
                double Debit = 0;
                double Last = Mahiber.LastFin;
                if (!Fundamental.IsChecked.GetValueOrDefault())
                {
                    var SelectedRule = ViolatedRuleId.SelectedItem;
                    Rule SelRule = ((Rule)SelectedRule);
                    SelRuleId = SelRule.Id;
                    rule = _context.Rules.FirstOrDefault(r => r.Id == SelRuleId);
                    First = Convert.ToDouble(rule.FirstFin);
                    Second = Convert.ToDouble(rule.SecondFin);
                    Last = Convert.ToDouble(rule.LastFin);

                }
                int PreRec = _context.Violations.Where(v => v.MemberId == SelMemId).Count();
                if (PreRec < 2)
                {
                    Debit = First;

                }
                else if (PreRec < 3)
                {
                    Debit = Second;

                }
                else if (PreRec < 4)
                {
                    Debit = Last;

                }
                Member Mem = ((Member)_context.Members.FirstOrDefault(m => m.Id == SelMemId));
                Mem.Debit += Debit;
                violation.Description = Description.Text.Trim();
                violation.MemberId = SelMemId;
                violation.RuleId = SelRuleId;

                _context.Entry(Mem).State = System.Data.Entity.EntityState.Modified;
                _context.Violations.Add(violation);
                _context.SaveChanges();
                SuccessMessage sm = new SuccessMessage();
                sm.MessageText.Text = "Reported Successfully";
                sm.Show();

            }
            catch (Exception)
            {
                ErrorMessage er = new ErrorMessage();
                er.MessageText.Text = "report not sent. try again";
                er.Show();
                
            }
        }

        private void Search_KeyUp(object sender, KeyEventArgs e)
        {
            List<Rule> Searched = new List<Rule>();
            foreach (Rule Rule in allRules)
            {
                if (Rule.Name.ToLower().Contains(Search.Text.ToString().ToLower()))
                {
                    Searched.Add(Rule);
                }
            }
            RulesGrid.ItemsSource = Searched;

        }

        private void Fundamental_Checked(object sender, RoutedEventArgs e)
        {
            ViolatedRuleId.IsEnabled = false;
        }

        private void Fundamental_Unchecked(object sender, RoutedEventArgs e)
        {
            ViolatedRuleId.IsEnabled = true;

        }

        private void refreshBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
