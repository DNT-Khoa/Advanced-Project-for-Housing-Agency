using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_housing_project
{
    class Events
    {
        private string hostName;
        private int hostID;
        private string title;
        private string description;
        private string date;

        public Events(Student student, string title, string date, string description)
        {
            this.hostName = student.FirstName + " " + student.LastName;
            this.hostID = student.IdNumber;
            this.title = title;
            this.description = description;
            this.date = date;
        }

        public string GetInfo()
        {
            return $"Event: {this.title}\nDescription: {this.description}\n" +
                $"Host name: {this.hostName}\nHost ID: {this.hostID}";
        }
    }
}
