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
    public partial class Login : Form
    {
        private bool isEmployee = false;
        private bool isOpenEmployee = false;
        private bool isOpenStudent = false;
        private House house = new House();
        private EmployeeForm ef;
        private StudentForm sf;

        public House House
        {
            get { return this.house; }
        }
        public Login()
        {
            InitializeComponent();
            cbxUserType.SelectedIndex = 0;
            ef = new EmployeeForm(this);
            sf = new StudentForm(this);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string text = cbxUserType.Text;
            //To close the login form after logging in use the following command.
            //this.Hide();
            switch (text)
            {
                case "Employee":
                    isEmployee = true;
                    if (!isOpenEmployee)
                    {
                        ef.Visible = true;
                        isOpenEmployee = true;
                    }
                    break;
                case "Student" :
                    isEmployee = false;
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
            sf.updateRules();
            ef.updateRules();
        }

        public void updateChores()
        {
            ef.updateChores();
        }
    }
}
