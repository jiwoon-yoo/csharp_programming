using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    
    internal class SalariedEmployee : Employee 
    {
        //fields and property 
        private double _weeklySalary;

        public double WeeklySalary
        {
            get => _weeklySalary;
            set => _weeklySalary = value; 
        }

        //constructor 
        public SalariedEmployee(string firstName, string lastName, int ssn, DateTime birthDate, double weeklySalary) : base(firstName, lastName, ssn, birthDate)
        {
            WeeklySalary = weeklySalary;    
        }


        //method 
        public override double Earnings() => WeeklySalary * 52 / 12;            // 52 weeks / 12 months 

        public override string ToString() => $"{base.ToString()} Weekly Salary : {WeeklySalary:C}";

    }
}
