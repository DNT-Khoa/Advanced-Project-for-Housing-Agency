using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_housing_project
{    
    public class Student
    {
        private static int idCounter = 0;
        private int Age;
        private string School;
        private string Course;

        public string FirstName { get; }
        public string LastName { get; }
        public int IdNumber { get { return idCounter; }}

        public Student(string firstName, string lastName, int age, string school,
            string course)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            idCounter++;
            this.Age = age;
            this.School = school;
            this.Course = course;
        }

        public string GetInfo()
        {
            return $"First Name: {this.FirstName}\nLast Name: {LastName}\n" +
                $"ID Number : {this.IdNumber}\nAge: {this.Age} \n" +
                $"School: {this.School}\nCourse: {this.Course} \n";
        }
    }
}
