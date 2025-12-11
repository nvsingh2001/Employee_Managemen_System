namespace Employee_Management_System;

internal class Company
{
    public string Name { get;}
    private int TotalNumberOfEmployees { get; set; }
    private double EmployeesPerHourWage { get; }
    private double TotalWage { set; get; }
    
    private int _numberOfEmployees;
    public Employee[] Employees { get; private set; }
    
    public Company(string name, int totalNumberOfEmployees, double employeesPerHourWage)
    {
        Name = name;
        TotalNumberOfEmployees = totalNumberOfEmployees;
        Employees = new Employee[TotalNumberOfEmployees];
        EmployeesPerHourWage = employeesPerHourWage;
        _numberOfEmployees = 0;
    }

    public void AddEmployee(string name, int age, String type)
    {
        if (_numberOfEmployees + 1 == Employees.Length)
        {
            var newArray = new Employee[TotalNumberOfEmployees * 2];
            for (int i = 0; i < TotalNumberOfEmployees; i++)
            {
                newArray[i] = Employees[i];
            }
            TotalNumberOfEmployees *= 2;
            Employees = newArray;
        }

        Employee employee;
        if (type == "Full Time")
        {
            employee = new FullTimeEmployee(_numberOfEmployees,name,age,true);
        }
        else
        {
            employee = new PartTimeEmployee(_numberOfEmployees, name, age, true);
        }
        
        employee.WagesPerHour = EmployeesPerHourWage;
        
        Employees[_numberOfEmployees++] = employee;
    }
    
    
    bool IsEmployeePresent(Employee employee)
    {
        int present = new Random().Next(0, 2);
        if(present == 1) return true;
        return false;
    }

    double CalculateDailyWage(Employee employee)
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

    double CalculateDailyWage(Employee employee,int hoursWorked)
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
    
    Tuple<double,int> CalculateMonthlyWage(Employee employee)
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

    double ComputeWage(Employee employee)
    {
        Tuple<double,int> monthlyData = CalculateMonthlyWage(employee);
        Console.WriteLine($"{employee.Name}'s Monthly Wages: ${monthlyData.Item1.ToString("F2")}, Hours Worked: {monthlyData.Item2}");
        return monthlyData.Item1;
    }

    public double ComputeEmployeeWage(Company company)
    {
        double totalWage = 0;
        foreach (var employee in company.Employees)
        {
            if (employee == null) break;
            totalWage += ComputeWage(employee);
        }
        
        TotalWage +=  totalWage;
        Console.WriteLine($"{company.Name} : ${totalWage}");
        
        return totalWage;
    }
}