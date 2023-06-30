using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal abstract class Employee
    {
        //fields and property 
        private string _firstName;
        private string _lastName;
        private int _ssn;
        private DateTime _birthDate;             //

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }
        public string LastName
        {
            set => _lastName = value;
            get => _lastName; 
        }
        public int Ssn
        {
            get => _ssn;
            set => _ssn = value;
        }
        public DateTime BirthDate
        {

            get => _birthDate;
            set => _birthDate = value;
        }
  


        //constructor
        public Employee(string firstName, string lastName, int ssn, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Ssn = ssn;
            BirthDate = birthDate;                  
        }




        //method 
        public abstract double Earnings();

        public override string ToString() => $"First Name : {FirstName} Last Name : {LastName} Social Security Number : {Ssn} BirthDate : {BirthDate}"; 

    }
}
