namespace Software_housing_project
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Complaint
    {
        private string date;
        private string description;

        public Complaint(string date, string description)
        {
            this.date = date;
            this.description = description;
        }

        public string GetInfo()
        {
            return $"{this.date} - {this.description}";
        }
    }
}
