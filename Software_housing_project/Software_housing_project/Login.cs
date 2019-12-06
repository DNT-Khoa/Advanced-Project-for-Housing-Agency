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
        public static bool isEmployee = false;
        StudentForm mf;
        EmployeeForm ef;

        public Login()
        {
            InitializeComponent();
            cbxUserType.SelectedIndex = 0;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string text = cbxUserType.Text;
            switch (text)
            {
                case "Employee":
                    isEmployee = true;
                    ef = new EmployeeForm();
                    ef.Visible = true;
                    break;
                case "Student" :
                    isEmployee = false;
                    mf = new StudentForm();
                    mf.Visible = true;
                    break;
            }
        }
    }
}
