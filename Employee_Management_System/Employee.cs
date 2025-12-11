namespace Employee_Management_System;

internal abstract class Employee(int id, string name, int dailyWorkingHours, int age, double wagesPerHour, bool isEmployeePresent, string type)
{
    public int Id { get; } = id; 
    public string Name { get; }  = name;
    public int Age { get;}   = age;
    public double WagesPerHour { get; set; } =  wagesPerHour;
    public bool IsEmployeePresent { get;  set; } = isEmployeePresent;
    public string Type { get; } = type;

    public int DailyWorkingHours { get; } = dailyWorkingHours;
    public override string ToString()
    {
        return $"Id: {Id}, Type: {Type}, Name: {Name}, Age: {Age} , WagesPerHour: {WagesPerHour}";
    }
}