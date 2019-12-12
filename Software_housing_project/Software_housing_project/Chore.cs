namespace Software_housing_project
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Chore
    {
        private string description;
        private string studentName;
        private string date;


        public Chore(string description, string studentName, string date)
        {
            this.description = description;
            this.studentName = studentName;
            this.date = date;
        }

        public string getChoreDescription()
        {
            return this.description;
        }

        public string getChoreStudentName()
        {
            return this.studentName;
        }

        public string getChoreDate()
        {
            return this.date;
        }

        public string GetInfo()
        {
            return $"{this.date} - {this.studentName} - {this.description}";
        }
    }
}
