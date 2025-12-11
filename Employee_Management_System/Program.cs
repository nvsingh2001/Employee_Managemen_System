using System.Collections;

namespace Employee_Management_System;

class Program
{
    
    static void Main(string[] args)
    {
        Company dmart = new Company("Dmart", 2, 20);
        
        dmart.AddEmployee("Naman Vinay Singh", 23, "Full Time");
        dmart.AddEmployee("Ankit Kumar", 23, "Part Time");
        
        Company reliance = new Company("Reliance", 2, 30);
        reliance.AddEmployee("Prashant Kumar", 23, "Full Time");
        reliance.AddEmployee("Madhav Sharma", 22, "Part Time");
        
        reliance.ComputeEmployeeWage(dmart);
        dmart.ComputeEmployeeWage(reliance);
    }
}