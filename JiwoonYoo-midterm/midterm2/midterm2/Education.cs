using midterm2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace midterm2
{
    internal class Education : Person
    {
        //fields and property 
        private int _educationId;
        private string _courseName;
        private double _courseGrade;
        private string _comment; 

        public int EducationId { get { return _educationId; } set { _educationId = value; } }
        public string CourseName { get { return _courseName; } set { _courseName = value; } }

        public double CourseGrade { get { return _courseGrade; } set { _courseGrade = value; } }
        public string Comment { get { return _comment; } set { _comment = value; } }        



        //constructor 
        public Education(int index, int personId, string name, string address, string email, int age, string birthDay, int educationId, string courseName, double courseGrade, string comment) : base(index, personId, name, address, email, age, birthDay)
        {
            EducationId = educationId;
            CourseName = courseName;
            CourseGrade = courseGrade; 
            Comment = comment; 

        }



    }
}
