Assignment Instructions:
• Create a program which will allow a company to pay its employees on a weekly basis.
• The employees are of four types:
Salaried employees are paid a fixed weekly salary regardless of the number of hours worked.
Hourly employees are paid by the hour and receive "time-and-a-half" overtime pay for all 
hours worked more than 40 hours.
Commission employees are paid a percentage of their sales.
Salaried-commission employees receive a base salary plus a percentage of their sales.
• For the current pay period, the company has decided to reward salaried-commission 
employees by adding 10% to their base salaries.
• The company wants to implement an app that performs its payroll calculations 
polymorphically.
• Use class Employee to represent the general concept of an employee (Abstract Class).
• SalariedEmployee, CommissionEmployee and HourlyEmployee extend Employee.
• Class SalaryPlusCommissionEmployee – which extends CommissionEmployee –
represents the last employee type.
Following diagram shows Class Hierarchy:
Hints:
• Base class Employee provides method Earnings, in addition to the properties that 
manipulate Employee’s instance variables.
• Each earnings calculation depends on the employee’s class, so we override Earnings in 
each class.
• The app iterates through the array and calls method Earnings for each Employee object. 
These method calls are processed polymorphically.
• The following diagram shows each of the five classes in the hierarchy down the left side 
and methods Earnings and ToString across the top.
• For each class, the diagram shows the desired results of each method.
Additional Requirements:
• Modify the payroll system to include private instance variable _birthDate in class 
Employee.
• Use type DateTime to represent an employee’s birthday.
• Assume that payroll is processed once per month.
• Create an array of Employee variables to store references to the various employee 
objects.
• In a loop, calculate the payroll for each Employee (polymorphically), and add a $100.00 
bonus to the person’s payroll amount if the current month is the month in which the 
Employee’s birthday occurs.



과제 지침:
• 회사가 주당 기준으로 직원에게 급여를 지급할 수 있는 프로그램을 생성합니다.
• 직원은 네 가지 유형이 있습니다:

정규직 직원은 근무한 시간과 상관없이 고정 주급을 받습니다.
시급제 직원은 시간당 급여를 받으며, 40시간을 초과하는 모든 시간에는 "1.5배의 시급"으로 초과근무수당을 받습니다.
커미션제 직원은 매출의 일정 비율을 급여로 받습니다.
정규직-커미션제 직원은 기본 급여와 매출의 일정 비율을 받습니다.
• 현재 급여 기간에 회사는 정규직-커미션제 직원의 기본 급여에 10%를 추가하여 보상하기로 결정했습니다.
• 회사는 직원 급여 계산을 다형적으로 수행하는 앱을 구현하고자 합니다.
• 추상 클래스인 Employee 클래스를 사용하여 직원의 일반 개념을 나타냅니다.
• SalariedEmployee, CommissionEmployee 및 HourlyEmployee는 Employee를 상속합니다.
• CommissionEmployee를 상속하는 SalaryPlusCommissionEmployee 클래스는 마지막 직원 유형을 나타냅니다.
다음 다이어그램은 클래스 계층 구조를 보여줍니다:
힌트:
• 기본 클래스인 Employee는 Employee의 인스턴스 변수를 조작하는 속성 외에도 Earnings 메서드를 제공합니다.
• 각 급여 계산은 직원의 클래스에 따라 다르므로 각 클래스에서 Earnings를 재정의합니다.
• 앱은 배열을 반복하고 각 직원 개체에 대해 Earnings 메서드를 호출합니다. 이 메서드 호출은 다형적으로 처리됩니다.
• 다음 다이어그램은 계층 구조의 각 클래스를 왼쪽에 나열하고 위에 Earnings 및 ToString 메서드를 표시합니다.
• 각 클래스에는 각 메서드의 원하는 결과가 표시됩니다.
추가 요구 사항:
• Employee 클래스에 비공개 인스턴스 변수 _birthDate를 포함하여 급여 체계를 수정합니다.
• 직원의 생일을 나타내기 위해 DateTime 유형을 사용합니다.
• 급여 체계는 매월 한 번 처리된다고 가정합니다.
• 다양한 직원 개체에 대한 참조를 저장하기 위해 Employee 변수의 배열을 생성합니다.
• 루프에서 각 직원의 급여를 계산하고 (다형적으로) 현재 월이 직원의 생일이 발생하는 달인 경우 급여에 $100.00 보너스를 추가합니다.
