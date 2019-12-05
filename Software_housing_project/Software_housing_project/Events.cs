using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_housing_project
{
    class Events
    {
        private string HostName;
        private int HostID;
        private string Title;
        private string Description;
        private string Date;

        public Events(Student student, string title, string date, string description)
        {
            this.HostName = student.FirstName + " " + student.LastName;
            this.HostID = student.IdNumber;
            this.Title = title;
            this.Description = description;
            this.Date = date;
        }

        public string GetInfo()
        {
            return $"Event: {this.Title}\nDescription: {this.Description}\n" +
                $"Host name: {this.HostName}\nHost ID: {this.HostID}";
        }
    }
}
