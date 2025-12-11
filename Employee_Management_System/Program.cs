using System.Collections;

namespace Employee_Management_System;

class Program
{
    static bool IsEmployeePresent(Employee employee)
    {
        int present = new Random().Next(0, 2);
        if(present == 1) return true;
        return false;
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

    static double CalculateDailyWage(Employee employee,int hoursWorked)
    {
        double wage = 0;
        if (IsEmployeePresent(employee)) return wage; 
        double performanceBonus = new Random().Next(0,2);
        switch (employee.Type)
        {
            case "Part Time":
                wage = (performanceBonus + hoursWorked) * employee.WagesPerHour;
                break;
            case "Full Time":
                wage = employee.WagesPerHour * hoursWorked;
                break;
        }
        return wage;
    }
    
    static Tuple<double,int> CalculateMonthlyWage(Employee employee)
    {
        Random random = new Random();
        double monthlyWage = 0;
        const int totalWorkingDay = 20;
        int totalHoursWorked = 0;
        const int maxWorkingHours = 120;
        for (int i = 1; i <= totalWorkingDay && totalHoursWorked <= maxWorkingHours; i++)
        {
            int hoursWorked = random.Next(2, employee.DailyWorkingHours + 1);
            double currentDayWage = CalculateDailyWage(employee, hoursWorked);

            if (currentDayWage != 0)
            {
                Console.WriteLine($"{employee.Name}'s Day: #{i} Wages: ${currentDayWage.ToString("F2")}");
            }
            
            monthlyWage += currentDayWage;
            totalHoursWorked += hoursWorked;
        }
        return new Tuple<double, int>(monthlyWage, totalHoursWorked);
    }

    static void ComputeWage(Employee employee)
    {
        Tuple<double,int> monthlyData = CalculateMonthlyWage(employee);
        Console.WriteLine($"{employee.Name}'s Monthly Wages: ${monthlyData.Item1.ToString("F2")}, Hours Worked: {monthlyData.Item2}");
    }
    
    static void Main(string[] args)
    {
        Employee employee1 = new FullTimeEmployee(101, "Naman Vinay Singh", 23,true);
        Employee employee2 = new PartTimeEmployee(102, "Ankit Kumar", 23, true);
        
        ComputeWage(employee1);
        ComputeWage(employee2);
    }
}