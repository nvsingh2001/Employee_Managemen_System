namespace Employee_Management_System;

internal class PartTimeEmployee: Employee
{
    public PartTimeEmployee(int id, string name, int age, bool isEmployeePresent) 
        : base(id, name, 4, age, 20.00, isEmployeePresent, "Part Time"){}
}