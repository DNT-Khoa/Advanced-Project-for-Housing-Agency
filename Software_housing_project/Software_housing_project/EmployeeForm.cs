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
                lbxTenants.Items.Add($"{student.FirstName} {student.LastName} ID: {student.IdNumber}");
            }
        }

        public void updateRules()
        {
            List<string> internalRules = GetRules();

            if (internalRules != House.rules)
            {
                lbxRules.Items.Clear();
                foreach (string rule in House.rules)
                {
                    lbxRules.Items.Add(rule);
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
            House.rules.Clear();
            House.updateRules();
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
            int tenantAge;
            tenantFirstName = tbxFirstName.Text;
            tenantLastName = tbxLastName.Text;
            tenantSchool = tbxSchool.Text;
            tenantCourse = tbxCourse.Text;
            tenantAge = Convert.ToInt32(tbxAge.Text);

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
            } else
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
            if (complaintsIndex > 0)
            {
                rtbComplaint.Text = House.complaints[--complaintsIndex].GetInfo();
            }
            else
            {
                //TODO ERROR MESSAGE (This is the first complaint)
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (complaintsIndex < House.complaints.Count - 1)
            {
                rtbComplaint.Text = House.complaints[++complaintsIndex].GetInfo();
            }
            else
            {
                //TODO ERROR MESSAGE (There are no more complaints)
            }

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            rtbComplaint.Clear();
            House.complaints.Clear();
            House.updateComplaints();
        }

        private void btnClearSelected_Click(object sender, EventArgs e)
        {
            House.complaints.RemoveAt(complaintsIndex);
            updateComplaints();
        }
    }
}
