using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_housing_project
{    
    class Student
    {
        static int idCounter = 0;
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private int IdNumber { get; }
        private int Age { get; set; }
        private string School { get; set; }
        private string Course { get; set; }
        private int ComplaintsMade {get; set;}
        
        public Student(string firstName, string lastName, int age, string school,
            string course)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.IdNumber = idCounter++;
            this.Age = age;
            this.School = school;
            this.Course = course;
            this.ComplaintsMade = 0;
        }

        public string GetInfo()
        {
            return $"First Name: {this.FirstName}\nLast Name: {LastName}\n" +
                $"ID Number : {this.IdNumber}\nAge: {this.Age} \n" +
                $"School: {this.School}\nCourse: {this.Course} \n" +
                $"Complaints made: {this.ComplaintsMade}";
        }


    }
}
