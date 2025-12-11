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
        int performanceBonus = new Random().Next(1, 5);
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
    
    static void Main(string[] args)
    {
        Employee employee1 = new FullTimeEmployee(101, "Naman Vinay Singh", 23,true);
        Employee employee2 = new PartTimeEmployee(102, "Ankit Kumar", 23, true);
        
        IsEmployeePresent(employee1);
        Console.WriteLine($"{employee1.Name}'s today's Wages: ${CalculateDailyWage(employee1)}");
        
        IsEmployeePresent(employee2);
        Console.WriteLine($"{employee2.Name}'s today's Wages: ${CalculateDailyWage(employee2)}");
    }
}