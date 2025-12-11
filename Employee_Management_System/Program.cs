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
    static void Main(string[] args)
    {
        Employee employee1 = new Employee(101, "Naman Vinay Singh", 23, true);
        
        IsEmployeePresent(employee1);
    }
}