using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_housing_project
{
    public class Event
    {
        private string hostName;
       // private int hostID;
        private string title;
        private string description;
        private string date;

        public Event(string hostName, string title, string date, string description)
        {
            this.hostName = hostName;
            //this.hostID = student.IdNumber;
            this.title = title;
            this.description = description;
            this.date = date;
        }

        public string GetInfo()
        {
            return $"Event: {this.title}\n\nDescription: {this.description}\n\n" +
                $"Host name: {this.hostName}";
        }
    }
}
