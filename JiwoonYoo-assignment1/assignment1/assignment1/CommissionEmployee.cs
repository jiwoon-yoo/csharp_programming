using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class CommissionEmployee : Employee 
    {
        //fields and property 
        private double grossSales; 
        private double commissionRate; 

        public double GrossSales
        {
            get => grossSales;
            set => grossSales = value;  
        }
        public double CommissionRate
        {
            get => commissionRate;
            set => commissionRate = value;
        }


        //constructor 
        public CommissionEmployee(string firstName, string lastName, int ssn, DateTime birthDate, double grossSale, double commissionRate) : base(firstName, lastName, ssn, birthDate) 
        {
            GrossSales = grossSale; 
            CommissionRate = commissionRate;    
        }



        //method 
        public override double Earnings() => CommissionRate * GrossSales;

        public override string ToString() => $"{base.ToString()} Commission : {Earnings():C}";


    }
}
