using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_housing_project
{
    public partial class StudentForm : Form
    {
        private LoginForm parentForm;
        private int complaintTracker; 
        public StudentForm(LoginForm parentForm)
        {
            InitializeComponent();
            
            this.parentForm = parentForm;
            this.complaintTracker = parentForm.House.Complaints.Count;
            FillDefaultTenants();

            mcEvents.MinDate = DateTime.Now;
            mcChore.MinDate = DateTime.Now;

            //Can add chore up to one week in the future.
            mcChore.MaxDate = DateTime.ParseExact(DateTime.Now.AddDays(7).ToShortDateString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            
            //Can file complaint as far as a year in the past and a year in the future.
            DateTime startOfPeriod = new DateTime(DateTime.Now.Year - 1, DateTime.Now.Month, DateTime.Now.Day);

            //Can arrange events up to a year in the future.
            DateTime startOfPeriodEvents = new DateTime(DateTime.Now.Year + 1, DateTime.Now.Month, DateTime.Now.Day);
            mcEvents.MaxDate = DateTime.ParseExact(startOfPeriodEvents.ToShortDateString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            mcComplaint.MinDate = DateTime.ParseExact(startOfPeriod.ToShortDateString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            mcComplaint.MaxDate = DateTime.ParseExact(DateTime.Now.ToShortDateString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            UpdateCheckBoxStudentsName();
            UpdateChoresDescriptions();
        }

        public void UpdateChores()
        {
            clbChores.Items.Clear();
            if(parentForm.House.Chores.Count > 0)
            {
                foreach (var chore in parentForm.House.Chores)
                {
                    clbChores.Items.Add(chore.GetInfo());
                }
            }
            
        }

        private void FillDefaultTenants()
        {
            parentForm.House.Tenants.Add(new Student("Marta", "Alston", 15, "Fontys", "ICT"));
            parentForm.House.Tenants.Add(new Student("Jim", "Bob", 19, "Fontys", "ICT"));
            parentForm.House.Tenants.Add(new Student("Elvis", "Presley", 20, "Fontys", "ICT"));
        }
        private void btnAddChore_Click(object sender, EventArgs e)
        {
            string selectedDate = mcChore.SelectionRange.Start.ToShortDateString();
            int result = DateTime.Compare(mcChore.SelectionRange.Start, mcChore.TodayDate);
            if (cbxName.SelectedIndex == -1)
            {
                MessageBox.Show("Select a correct student name!");
            }
            else if(cbxChore.SelectedIndex == -1)
            {
                MessageBox.Show("Select a correct chore!");
            }
            else if(String.Compare(selectedDate, string.Empty) == 0)
            {
                MessageBox.Show("Select a correct date!");
            } else if (result < 0)
            {
                MessageBox.Show("You cannot choose a date from the past! It doesn't make sense.");
            }
            else
            {
                if (ChoreIsValid(cbxChore.SelectedItem.ToString(), cbxName.SelectedItem.ToString(), selectedDate))
                {
                    Chore chore = new Chore(cbxChore.SelectedItem.ToString(), cbxName.SelectedItem.ToString(), selectedDate);

                    parentForm.House.Chores.Add(chore);

                    clbChores.Items.Add(chore.GetInfo());

                    parentForm.UpdateChores();
                }
                else
                {
                    MessageBox.Show("The same person should not do the same chore on the same day more than one time! Do you think so?");
                }
                
            }    
        }

        private bool ChoreIsValid(string choreName, string studentName, string choreDate)
        {
            foreach(Chore chore in parentForm.House.Chores)
            {
                if (chore.getChoreDescription() == choreName && chore.getChoreStudentName() == studentName && chore.getChoreDate() == choreDate)
                {
                    return false;
                } 
            }
            return true;
        }
        //Rules page
        public void UpdateRules()
        {
            List<string> internalRules = GetRules();
            int lineIndex = 1;
            if (internalRules != parentForm.House.Rules)
            {
                lbxRules.Items.Clear();
                foreach (string rule in parentForm.House.Rules)
                {
                    lbxRules.Items.Add(lineIndex.ToString() + ". " + rule);
                    lineIndex++;
                }
            }
        }
        //Rules page
        private List<string> GetRules()
        {
            List<string> internalRules = new List<string>();
            foreach (string rule in lbxRules.Items)
            {
                internalRules.Add(rule);
            }
            return internalRules;
        }
        public void UpdateCheckBoxStudentsName()
        {
            cbxName.Items.Clear();
            cbxEventHost.Items.Clear();
            foreach (var student in parentForm.House.Tenants)
            {
                cbxName.Items.Add($"{student.FirstName}  Id:{student.IdNumber}");
                cbxEventHost.Items.Add($"{student.FirstName}  Id:{student.IdNumber}");
            }
        }

        private void UpdateChoresDescriptions()
        {
            cbxChore.Items.Add("Wash the dishes.");
            cbxChore.Items.Add("Take out the garbage.");
            cbxChore.Items.Add("Go grocery shopping.");
            cbxChore.Items.Add("Clean toilet.");
        }

        private void btnFileComplaint_Click(object sender, EventArgs e)
        {
            string selectedDate = mcComplaint.SelectionRange.Start.ToShortDateString(); 

            if (String.Compare(rtbDescription.Text, string.Empty) == 0 || String.Compare(rtbDescription.Text, "Description") == 0)
            {
                MessageBox.Show("Write a meaningful description!");
            }
            else if (String.Compare(selectedDate, string.Empty) == 0)
            {
                MessageBox.Show("Select a correct date!");
            }
            else
            {
                Complaint complaint = new Complaint(selectedDate, rtbDescription.Text);
                parentForm.House.Complaints.Add(complaint);
                rtbComplaints.Text = complaint.GetInfo();
                parentForm.UpdateComplaints();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(parentForm.House.Complaints.Count != 0)
            {
                btnNext.Enabled = true;

                if (complaintTracker > 0)
                {
                    rtbComplaints.Text = parentForm.House.Complaints[--complaintTracker].GetInfo();
                }
                else
                {
                    btnPrevious.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("There are no complaints!");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(parentForm.House.Complaints.Count != 0)
            {
                btnPrevious.Enabled = true;

                if (complaintTracker < parentForm.House.Complaints.Count -1)
                {
                    rtbComplaints.Text = parentForm.House.Complaints[++complaintTracker].GetInfo();
                }
                else
                {
                    btnNext.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("There are no complaints!");
            }
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {                      
            if(cbxEventHost.SelectedIndex != -1 && cbxEventHost.Text != "")
            {
                string name = cbxEventHost.SelectedItem.ToString();
                if(tbxEventTitle.Text != "" && tbxEventTitle.Text != "Event Title")
                {
                    string title = tbxEventTitle.Text;
                    if(mcEvents.SelectionRange.Start.ToShortDateString() != "")
                    {
                        string date = mcEvents.SelectionRange.Start.ToShortDateString();
                        if (rtbEventDescription.Text != "" && rtbEventDescription.Text != "Description")
                        {
                            string description = rtbEventDescription.Text;
                            parentForm.House.Events.Add(new Event(name, title, date, description));
                            clbEvents.Items.Add($"{date} {title} : {name}");
                        }
                        else
                        {
                            MessageBox.Show("Please enter a proper description");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a date");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a title");
                }
            }
            else
            {
                MessageBox.Show("Please enter a student");
            }
        }

        private void btnShowInfoEvent_Click(object sender, EventArgs e)
        {

            int index = clbEvents.SelectedIndex;
            if(index == -1)
            {
                MessageBox.Show("Select an event!");
            }
            else
            {
                string info = parentForm.House.Events[index].GetInfo();
                MessageBox.Show(info);
            }
        }


        public void UpdateComplaints()
        {
            rtbComplaints.Clear();
            rtbComplaints.Text = parentForm.House.Complaints[complaintTracker].GetInfo();
        }
        
        
        private void clbChores_DoubleClick(object sender, EventArgs e)
        {
            parentForm.House.Chores.RemoveAt(this.clbChores.SelectedIndex);
            this.clbChores.Items.Remove(this.clbChores.SelectedItem);
            parentForm.UpdateChores();
        }

    }
}
