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
        House house = new House();

        public Login()
        {
            InitializeComponent();
            cbxUserType.SelectedIndex = 0;
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
                    break;
                case "Student" :
                    isEmployee = false;
                    break;
            }
            house.Login(isEmployee);
        }
    }
}
