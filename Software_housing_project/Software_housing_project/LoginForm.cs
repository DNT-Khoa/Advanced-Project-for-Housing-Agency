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
    public partial class LoginForm : Form
    {
        
        private bool isOpenEmployee = false;
        private bool isOpenStudent = false;
        private House house = new House();
        private EmployeeForm ef;
        private StudentForm sf;

        public House House
        {
            get { return this.house; }
        }
        public LoginForm()
        {
            InitializeComponent();
            cbxUserType.SelectedIndex = 0;
            ef = new EmployeeForm(this);
            sf = new StudentForm(this);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string text = cbxUserType.Text;
            switch (text)
            {
                case "Employee":
                    
                    if (!isOpenEmployee)
                    {
                        ef.Visible = true;
                        isOpenEmployee = true;
                    }
                    break;
                case "Student" :
                    
                    if (!isOpenStudent)
                    {
                        sf.Visible = true;
                        isOpenStudent = true;
                    }
                    break;
            }
        }

        public void updateRules()
        {
            sf.UpdateRules();
            ef.updateRules();
        }

        public void updateChores()
        {
            ef.UpdateChores();
        }

        public void updateComplaints()
        {
            ef.UpdateComplaints();
            sf.UpdateComplaints();
        }

        public void UpdateCheckBoxStudentsName()
        {
            foreach (var student in this.House.Tenants)
            {
                sf.UpdateCheckBoxStudentsName();
            }
        }
    }
}
