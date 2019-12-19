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
        private List<Complaint> complaints = new List<Complaint>();
        private List<Chore> chores = new List<Chore>();
        private List<Event> events = new List<Event>();

       
        public List<Chore> Chores
        {
            get { return this.chores; }
        }

        public List<Event> Events
        {
            get { return this.events; }
        }

        public List<Complaint> Complaints
        {
            get { return this.complaints; }
        }
        
    }
}
