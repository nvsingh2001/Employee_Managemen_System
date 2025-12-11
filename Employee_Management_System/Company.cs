namespace Employee_Management_System;

internal class Company
{
    public string Name { get;}
    private int TotalNumberOfEmployees { get; set; }
    private double EmployeesPerHourWage { get; }
    private int numberOfEmployees;
    public Employee[] employees { get; private set; }
    

    public Company(string name, int totalNumberOfEmployees, double employeesPerHourWage)
    {
        Name = name;
        TotalNumberOfEmployees = totalNumberOfEmployees;
        employees = new Employee[TotalNumberOfEmployees];
        EmployeesPerHourWage = employeesPerHourWage;
        numberOfEmployees = 0;
    }

    public void AddEmployee(string name, int age, String type)
    {
        if (numberOfEmployees + 1 == employees.Length)
        {
            var newArray = new Employee[TotalNumberOfEmployees * 2];
            for (int i = 0; i < TotalNumberOfEmployees; i++)
            {
                newArray[i] = employees[i];
            }
            TotalNumberOfEmployees *= 2;
            employees = newArray;
        }

        Employee employee;
        if (type == "Full Time")
        {
            employee = new FullTimeEmployee(numberOfEmployees,name,age,true);
        }
        else
        {
            employee = new PartTimeEmployee(numberOfEmployees, name, age, true);
        }
        
        employee.WagesPerHour = EmployeesPerHourWage;
        
        employees[numberOfEmployees++] = employee;
    }
}