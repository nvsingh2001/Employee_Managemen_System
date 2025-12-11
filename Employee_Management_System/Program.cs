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

    static double CalculateDailyWage(Employee employee,int hoursWorked)
    {
        double wage = 0;
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
    
    static void CalculateMonthlyWage(Employee employee)
    {
        Random random = new Random();
        double monthlyWage = 0;
        int totalWorkingDay = random.Next(1,21);
        int totalHoursWorked = 0;
        const int maxWorkingHours = 120;
        for (int i = 1; i <= totalWorkingDay && totalHoursWorked <= maxWorkingHours; i++)
        {
            int hoursWorked = random.Next(2, employee.DailyWorkingHours + 1);
            monthlyWage += CalculateDailyWage(employee, hoursWorked);
            totalHoursWorked += hoursWorked;
        }
        Console.WriteLine($"{employee.Name}'s Monthly Wages: ${monthlyWage.ToString("F2")}, Hours Worked: {totalHoursWorked}");
    }
    
    static void Main(string[] args)
    {
        Employee employee1 = new FullTimeEmployee(101, "Naman Vinay Singh", 23,true);
        Employee employee2 = new PartTimeEmployee(102, "Ankit Kumar", 23, true);
        
        IsEmployeePresent(employee1);
        Console.WriteLine($"{employee1.Name}'s today's Wages: ${CalculateDailyWage(employee1).ToString("F2")}");
        CalculateMonthlyWage(employee1);
        
        IsEmployeePresent(employee2);
        Console.WriteLine($"{employee2.Name}'s today's Wages: ${CalculateDailyWage(employee2).ToString("F2")}");
        CalculateMonthlyWage(employee2);
    }
}