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

        public void UpdateRules()
        {
            sf.UpdateRules();
            ef.UpdateRules();
        }

        public void UpdateChores()
        {
            ef.UpdateChores();
            sf.UpdateChores();
        }

        public void UpdateComplaints()
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

        private void timerTrash_Tick(object sender, EventArgs e)
        {
            UpdateChores();
            //UpdateComplaints();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //serialPort1.Open();
            timerTrash.Start();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {          
            serialPort1.Close();
            timerTrash.Stop();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (serialPort1.BytesToRead > 0)
            {
                if (serialPort1.ReadLine().Trim() == "t")
                {
                    for (int i = 0; i < House.Chores.Count; i++)
                    {
                        if (House.Chores[i].getChoreDescription() == "Take out the garbage.")
                        {
                            House.Chores.RemoveAt(i);
                            MessageBox.Show("Trash collected");
                            break;
                        }
                    }
                }
            }
        }

    }
}
