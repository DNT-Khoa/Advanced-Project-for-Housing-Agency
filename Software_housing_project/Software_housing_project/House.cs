using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_housing_project
{
    public class House
    {
        public static List<Student> tenants = new List<Student>();
        public static List<string> rules = new List<string>();
        public static List<Complaint> complaints = new List<Complaint>();
        public static List<Chore> chores = new List<Chore>();
        public static List<Event> events = new List<Event>();

        static EmployeeForm ef = new EmployeeForm();
        static StudentForm sf = new StudentForm(); 



        public void Login(bool isEmployee)
        {
            if (isEmployee)
            {
                ef.Visible = true;
            }
            else
            {
                sf.Visible = true;
            }
        }

        public static void updateRules()
        {
            sf.updateRules();
        }
    }
}
