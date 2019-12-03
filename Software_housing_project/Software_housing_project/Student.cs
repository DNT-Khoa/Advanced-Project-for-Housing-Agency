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
        private string firstName { get; set; }
        private string lastName { get; set; }
        private int idNumber { get; }
        private int age { get; set; }
        private string school { get; set; }
        private string course { get; set; }
        private int nrOfComplaintsMade {get; set;}
        
        public Student(string firstName, string lastName, int age, string school,
            string course)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.idNumber = idCounter++;
            this.age = age;
            this.school = school;
            this.course = course;
            this.nrOfComplaintsMade = 0;
        }

        public string GetInfo()
        {
            return $"First Name: {this.firstName}\nLast Name: {lastName}\n" +
                $"ID Number : {this.idNumber}\nAge: {this.age} \n" +
                $"School: {this.school}\nCourse: {this.course} \n" +
                $"Complaints made: {nrOfComplaintsMade}";
        }


    }
}
