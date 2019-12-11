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
        int complaintsIndex = 0;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void updateRules()
        {
            House.updateRules();
        }

        public void updateComplaints()
        {
            rtbComplaint.Text = House.complaints[complaintsIndex].GetInfo();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(complaintsIndex > 0)
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
            if (complaintsIndex < House.complaints.Count-1)
            {
                rtbComplaint.Text = House.complaints[++complaintsIndex].GetInfo();
            }
            else
            {
                //TODO ERROR MESSAGE (There are no more complaints)
            }
        }

        private void btnClearSelected_Click(object sender, EventArgs e)
        {
            House.complaints.RemoveAt(complaintsIndex);
            updateComplaints();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            rtbComplaint.Clear();
            House.complaints.Clear();
            House.updateComplaints();
        }
    }
}
