using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class BasePlusCommissionEmployee : CommissionEmployee
    {
        //fields and property 

        private double _baseSalary; 

        public double BaseSalary
        {
            get => _baseSalary;
            set => _baseSalary = value;
        }


        //constructor 
        public BasePlusCommissionEmployee(string firstName, string lastName, int ssn, DateTime birthDate, double grossSale, double commissionRate, double baseSalary) : base(firstName, lastName, ssn, birthDate, grossSale, commissionRate)
        {
            BaseSalary = baseSalary; 
        }



        //method 
        public override double Earnings() => 4*BaseSalary * 1.1  + CommissionRate * GrossSales;             //4weeks in a month 

        public override string ToString() => $"{base.ToString()} Commission with Base Salary : {Earnings():C}";
    }
}
