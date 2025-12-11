namespace Employee_Management_System;

internal class FullTimeEmployee: Employee
{
    public FullTimeEmployee(int id, string name, int age, bool isEmployeePresent) 
        : base(id, name, 8, age, 20.00, isEmployeePresent, "Full Time"){}
}