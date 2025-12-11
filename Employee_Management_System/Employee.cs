namespace Employee_Management_System;

internal class Employee(int id, string name, int age,  bool isFullTime, double wagesPerHour)
{
    public int Id { get; } = id; 
    public string Name { get; }  = name;
    public int Age { get;}   = age;
    public bool IsFullTime { get; set; } =  isFullTime;
    public double WagesPerHour { get; set; } =  wagesPerHour; 
    
    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Age: {Age} , IsFullTime: {IsFullTime} , WagesPerHour: {WagesPerHour}";
    }
}