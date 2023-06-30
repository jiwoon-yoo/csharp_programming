using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] empArr = new Employee[100];                 
            int count = 0;
            int employeeType; 
            string firstName;
            string lastName;
            int ssn;
            int birthYear;
            int birthMonth;
            int birthDay;
            DateTime birthDate;
            double weeklySalary;
            double monthEarning;
            double grossSales;
            double commissionRate;
            double wage;
            int workingHoursInFirstWeek;
            int workingHoursInSecondWeek;
            int workingHoursInThirdWeek;
            int workingHoursInFourthWeek;
            double baseSalary;
            int keepGoing; 


            do 
            { 
                Console.WriteLine("payroll calculation program");
                Console.WriteLine("enter your first name");
                firstName = Console.ReadLine();
                Console.WriteLine("enter your last name");
                lastName = Console.ReadLine();
                Console.WriteLine("enter your ssn");
                ssn = int.Parse(Console.ReadLine());
                Console.WriteLine("enter your birth year");
                birthYear = int.Parse(Console.ReadLine());
                Console.WriteLine("enter your birth month(ex. 1 or 2 or 3 or ...)");
                birthMonth = int.Parse(Console.ReadLine());
                Console.WriteLine("enter your birth day");
                birthDay = int.Parse(Console.ReadLine());

                birthDate = new DateTime(birthYear, birthMonth, birthDay);

                Console.WriteLine("enter what type of employee you are");
                Console.WriteLine("1:Salaried employees");
                Console.WriteLine("2:Commission employees"); 
                Console.WriteLine("3:Hourly employees");
                Console.WriteLine("4:Salaried-commission employees(BasePlusCommissionEmployee)");
                employeeType = int.Parse(Console.ReadLine());   


                switch (employeeType)
                {
                    case 1:
                 
                        Console.WriteLine("enter weeklysalary. It will calculate your salary for a month");
                        weeklySalary = double.Parse(Console.ReadLine());

                        empArr[count] = new SalariedEmployee(firstName, lastName, ssn, birthDate, weeklySalary);
             

                        monthEarning = empArr[count].Earnings();                          

                        if (empArr[count].BirthDate.Month == DateTime.Now.Month)
                        {
                            monthEarning += 100.00; 
                        }

                        Console.WriteLine($"your salary of this month : {monthEarning:C}");    
                        count++;
                        break;
                    case 2:
             
                        Console.WriteLine("enter Gross Sales in a month");
                        grossSales = double.Parse(Console.ReadLine());
                        Console.WriteLine("enter Commission Rate");
                        commissionRate = double.Parse(Console.ReadLine());

                        empArr[count] = new CommissionEmployee(firstName, lastName, ssn, birthDate, grossSales, commissionRate);

                        monthEarning = empArr[count].Earnings();

                        if (empArr[count].BirthDate.Month == DateTime.Now.Month)
                        {
                            monthEarning += 100.00;
                        }

                        Console.WriteLine($"your salary of this month : {monthEarning:C}");               
                        count++;
                        break;
                    case 3:
                   
                        Console.WriteLine("enter Wage");
                        wage = double.Parse(Console.ReadLine());
                        Console.WriteLine("enter working hours in the first week");
                        workingHoursInFirstWeek = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter working hours in the second week");
                        workingHoursInSecondWeek = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter working hours in the third week");
                        workingHoursInThirdWeek = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter working hours in the fourth week");
                        workingHoursInFourthWeek = int.Parse(Console.ReadLine());

                        empArr[count] = new HourlyEmployee(firstName, lastName, ssn, birthDate, wage, workingHoursInFirstWeek, workingHoursInSecondWeek, workingHoursInThirdWeek, workingHoursInFourthWeek);

                        monthEarning = empArr[count].Earnings();                               

                        if (empArr[count].BirthDate.Month == DateTime.Now.Month)
                        {
                            monthEarning += 100.00;
                        }
                        Console.WriteLine($"your salary of this month : {monthEarning:C}");
                        count++;
                        break;
                    case 4:
         
                        Console.WriteLine("For the current pay period, the company has decided to reward you by adding 10% to your base salary per week");
                        Console.WriteLine("enter base salary");
                        baseSalary = double.Parse(Console.ReadLine());
                        Console.WriteLine("enter Gross Sales in a month");
                        grossSales = double.Parse(Console.ReadLine());
                        Console.WriteLine("enter Commission Rate");
                        commissionRate = double.Parse(Console.ReadLine());

                        empArr[count] = new BasePlusCommissionEmployee(firstName, lastName, ssn, birthDate, grossSales, commissionRate, baseSalary);

                        monthEarning = empArr[count].Earnings();


                        if (empArr[count].BirthDate.Month == DateTime.Now.Month)
                        {
                            monthEarning += 100.00;
                        }

                        Console.WriteLine($"your salary of this month : {monthEarning:C}");
                        count++;

                        break;
                    default:
                        Console.WriteLine("you entered the wrong type");

                        break;
                }

                Console.WriteLine("do you want to keep going(1 for yes / 2 for no)"); 
                keepGoing = int.Parse(Console.ReadLine()); 
            }while(keepGoing == 1); 




            Console.WriteLine(); 

            Console.WriteLine("total payroll list");
            for (int i = 0 ; i < count; i++)
            {
                Console.WriteLine(empArr[i].ToString()); 
            }

          

        }
    }
}
