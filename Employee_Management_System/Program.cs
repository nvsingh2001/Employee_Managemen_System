namespace Employee_Management_System;

class Program
{
    static void IsEmployeePresent(Employee employee)
    {
        if (employee.IsFullTime)
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
        int hoursWorked = new Random().Next(1, 10);
        return employee.WagesPerHour * hoursWorked;
    }
    static void Main(string[] args)
    {
        Employee employee1 = new Employee(101, "Naman Vinay Singh", 23, true, 20.00);
        
        IsEmployeePresent(employee1);
        Console.WriteLine($"{employee1.Name}'s today's Wages: ${CalculateDailyWage(employee1)}");
    }
}