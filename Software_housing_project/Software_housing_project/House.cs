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
        private List<Chore> chores = new List<Chore>();
        public static List<Event> events = new List<Event>();

        public void AddChore(Chore chore)
        {
            this.chores.Add(chore);
        }

        public List<Chore> Chores
        {
            get { return this.chores; }
        }
        public static void updateRules()
        {
            //sf.updateRules();
            //ef.updateRules();
        }

        public static void updateComplaints()
        {
            //ef.updateComplaints();
            //sf.updateComplaints();
        }

        public static void UpdateCheckBoxStudentsName()
        {
            foreach (var student in House.tenants)
            {
                //sf.UpdateCheckBoxStudentsName();
            }
        }

        public static void updateChores()
        {
            //ef.updateChores();
        }

    }
}
