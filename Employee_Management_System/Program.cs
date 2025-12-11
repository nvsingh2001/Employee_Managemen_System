namespace Employee_Management_System;

class Program
{
    static void IsEmployeePresent(Employee employee)
    {
        if (employee.IsEmployeePresent)
        {
            Console.WriteLine($"{employee.Name} is Present");
        }
        else
        {
            Console.WriteLine($"{employee.Name} is not Present");
        }
    }

    static double CalculateDailyWage(Employee employee)
    {
        double wage = 0;
        int hoursWorked = new Random().Next(employee.DailyWorkingHours + 1);
        double performanceBonus = new Random().NextDouble();
        switch (employee.Type)
        {
            case "Part Time":
                wage = (performanceBonus + hoursWorked) * employee.WagesPerHour;
                break;
            case "Full Time":
                wage = employee.WagesPerHour * (employee.DailyWorkingHours - hoursWorked);
                break;
        }
        return wage;
    }

    static double CalculateMonthlyWage(Employee employee)
    {
        double monthlyWage = 0;
        int totalWorkingDay = new Random().Next(21);
        for (int i = 1; i <= totalWorkingDay; i++)
        {
            monthlyWage += CalculateDailyWage(employee);
        }
        return monthlyWage;
    }
    
    static void Main(string[] args)
    {
        Employee employee1 = new FullTimeEmployee(101, "Naman Vinay Singh", 23,true);
        Employee employee2 = new PartTimeEmployee(102, "Ankit Kumar", 23, true);
        
        IsEmployeePresent(employee1);
        Console.WriteLine($"{employee1.Name}'s today's Wages: ${CalculateDailyWage(employee1).ToString("F2")}");
        Console.WriteLine($"{employee1.Name}'s Monthly Wages: ${CalculateMonthlyWage(employee1).ToString("F2")}");
        
        IsEmployeePresent(employee2);
        Console.WriteLine($"{employee2.Name}'s today's Wages: ${CalculateDailyWage(employee2).ToString("F2")}");
        Console.WriteLine($"{employee2.Name}'s Monthly Wages: ${CalculateMonthlyWage(employee2).ToString("F2")}");
    }
}