using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class HourlyEmployee : Employee 
    {
        //fields and property 
        private double _wage;
        private int _workingHoursInFirstWeek; 
        private int _workingHoursInSecondWeek;
        private int _workingHoursInThirdWeek;
        private int _workingHoursInFourthWeek;


        public double Wage
        {
            get => _wage;
            set => _wage = value;
        }

        public int WorkingHoursInFirstWeek
        {
            get => _workingHoursInFirstWeek; 
            set => _workingHoursInFirstWeek = value;
        }

        public int WorkingHoursInSecondWeek
        {
            get => _workingHoursInSecondWeek;
            set => _workingHoursInSecondWeek = value;
        }
        public int WorkinghoursInThirdWeek
        {
            get => _workingHoursInThirdWeek;
            set => _workingHoursInThirdWeek = value;
        }
        public int WorkingHoursInFourthWeek
        {
            get => _workingHoursInFourthWeek;
            set => _workingHoursInFourthWeek = value;
        }


        //constructor 
        public HourlyEmployee(string firstName, string lastName, int ssn, DateTime birthDate, double wage, int workingHoursInFirstWeek,int workingHoursInSecondWeek, int workingHoursInThirdWeek, int workingHoursInFourthWeek) : base(firstName, lastName, ssn, birthDate)
        {
            Wage = wage;
            WorkingHoursInFirstWeek = workingHoursInFirstWeek;
            WorkingHoursInSecondWeek = workingHoursInSecondWeek;
            WorkinghoursInThirdWeek = workingHoursInThirdWeek;
            WorkingHoursInFourthWeek = workingHoursInFourthWeek;
        }



        //method 
        public override double Earnings()
        {
            double totalEarningInMonth = 0; 

            if (WorkingHoursInFirstWeek <= 40)
            {
                totalEarningInMonth += Wage * WorkingHoursInFirstWeek;
            }
            else
            {
                totalEarningInMonth += 40 * Wage + (WorkingHoursInFirstWeek - 40) * Wage * 1.5;
            }


            
            if (WorkingHoursInSecondWeek <= 40)
            {
                totalEarningInMonth += Wage * WorkingHoursInSecondWeek;
            }
            else
            {
                totalEarningInMonth += 40 * Wage + (WorkingHoursInSecondWeek - 40) * Wage * 1.5;
            }



            
            if (WorkinghoursInThirdWeek <= 40)
            {
                totalEarningInMonth += Wage * WorkinghoursInThirdWeek; 
            }
            else
            {
                totalEarningInMonth += 40 * Wage + (WorkinghoursInThirdWeek - 40) * Wage * 1.5;
            }


            
            if (WorkingHoursInFourthWeek <= 40)
            {
                totalEarningInMonth += Wage * WorkingHoursInFourthWeek;
            }
            else
            {
                totalEarningInMonth += 40 * Wage + (WorkingHoursInFourthWeek - 40) * Wage * 1.5;
            }


            return totalEarningInMonth; 
        }


        public override string ToString() => $"{base.ToString()} Total Wage : {Earnings():C}";
    }
}
