using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_housing_project
{
    public partial class EmployeeForm : Form
    {
        private int complaintsIndex = 0;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            foreach (Student student in House.tenants) {
                lbxTenants.Items.Add($"{student.FirstName} {student.LastName} Id: {student.IdNumber}");
            }
        }

        public void updateRules()
        {
            List<string> internalRules = GetRules();
            int lineIndex = 0;
            if (internalRules != House.rules)
            {
                lbxRules.Items.Clear();
                foreach (string rule in House.rules)
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

        public void updateComplaints()
        {
            rtbComplaint.Text = House.complaints[complaintsIndex].GetInfo();
        }

        public void updateChores()
        {
            lbxChores.Items.Clear();
            foreach (var chore in House.chores)
            {
                lbxChores.Items.Add(chore.GetInfo());
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (rtbRulesToAdd.Text == "")
            {
                MessageBox.Show("Did you forget to fill in the rule before trying to add it to the rule list ?");
                rtbRulesToAdd.Text = "";
            } else
            {
                House.rules.Add(rtbRulesToAdd.Text);
                House.updateRules();
                rtbRulesToAdd.Text = "";
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if (lbxRules.Items.Count == 0)
            {
                MessageBox.Show("There's nothing left to be removed!");
            } else
            {
                House.rules.Clear();
                House.updateRules();
            }      
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (lbxRules.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a rule to be removed from the list !");
            } else
            {
                House.rules.RemoveAt(lbxRules.SelectedIndex);
                House.updateRules();
            }
        }

        private void btnAddTenant_Click(object sender, EventArgs e)
        {
            string tenantFirstName, tenantLastName, tenantSchool, tenantCourse;
            int tenantAge, numberToCheck;
            tenantFirstName = tbxFirstName.Text;
            tenantLastName = tbxLastName.Text;
            tenantSchool = tbxSchool.Text;
            tenantCourse = tbxCourse.Text;
            
            bool isInteger = int.TryParse(tbxAge.Text, out numberToCheck);

            if (tenantFirstName == "")
            {
                MessageBox.Show("Please indicate the first name of the tenant !");
            } else if (tenantLastName == "")
            {
                MessageBox.Show("Please indicate the last name of the tenant !");
            } else if (tenantSchool == "")
            {
                MessageBox.Show("Did you forget to fill in the school field ?");
            } else if (tenantCourse == "")
            {
                MessageBox.Show("You need to fill the name of the course !");
            } else if (tbxAge.Text == "")
            {
                MessageBox.Show("I wonder what is the name of the tenant ?");
            } else if (!isInteger)
            {
                MessageBox.Show("The age you enter is not an integer !");
            } 
            else
            {
                tenantAge = Convert.ToInt32(tbxAge.Text);
                if (tenantAge <= 0)
                {
                    MessageBox.Show("Either you are not existing or you are making a mistake !?");
                    tbxAge.Text = "";
                }
                else if (tenantAge > 100)
                {
                    MessageBox.Show("You are way too old to rent a room in our agency!");
                    tbxAge.Text = "";
                }
                else
                {
                    House.tenants.Add(new Student(tenantFirstName, tenantLastName, tenantAge, tenantSchool, tenantCourse));
                    lbxTenants.Items.Add($"{tenantFirstName} {tenantLastName} ID: {House.tenants[House.tenants.Count - 1].IdNumber}");
                    House.UpdateCheckBoxStudentsName();

                    tbxFirstName.Text = "";
                    tbxLastName.Text = "";
                    tbxSchool.Text = "";
                    tbxCourse.Text = "";
                    tbxAge.Text = "";
                }
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            if (lbxTenants.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a tenant to retrieve information from !");
            } else
            {
                MessageBox.Show(House.tenants[lbxTenants.SelectedIndex].GetInfo());
            }
        }

        private void btnRemoveTenant_Click(object sender, EventArgs e)
        {
            if (lbxTenants.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a tenant to be removed");
            } else
            {
                House.tenants.RemoveAt(lbxTenants.SelectedIndex);
                lbxTenants.Items.RemoveAt(lbxTenants.SelectedIndex);
                House.UpdateCheckBoxStudentsName();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (House.complaints.Count != 0)
            {
                if (complaintsIndex > 0)
                {
                    rtbComplaint.Text = House.complaints[--complaintsIndex].GetInfo();
                }
                else
                {
                    MessageBox.Show("This is the first complaint");

                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (House.complaints.Count != 0)
            {
                if (complaintsIndex < House.complaints.Count - 1)
                {
                    rtbComplaint.Text = House.complaints[++complaintsIndex].GetInfo();
                }
                else
                {
                    MessageBox.Show("This is the last complaint. Go back!");

                }
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if(House.complaints.Count > 0)
            {
                rtbComplaint.Clear();
                House.complaints.Clear();
                House.updateComplaints();
            }
            else
            {
                MessageBox.Show("List is already empty");
            }
           
        }

        private void btnClearSelected_Click(object sender, EventArgs e)
        {
            if(House.complaints.Count > complaintsIndex)
            {
                House.complaints.RemoveAt(complaintsIndex);
                updateComplaints();
            }
            else
            {
                MessageBox.Show("There is nothing selected");
            }          
        }
    }
}
