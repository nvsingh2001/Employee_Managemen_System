using System.Collections;

namespace Employee_Management_System;

class Program
{
    
    static void Main(string[] args)
    {

        Compaines compaines = new Compaines(2);
        
        
        compaines.AddCompany(new Company(0,"Dmart", 2, 20));
        compaines.GetCompany(0).AddEmployee("Naman Vinay Singh", 23, "Full Time");
        compaines.GetCompany(0).AddEmployee("Ankit Kumar", 23, "Part Time");
        
        compaines.AddCompany(new Company(1,"Reliance", 2, 30));
        compaines.GetCompany(1).AddEmployee("Prashant Kumar", 23, "Full Time");
        compaines.GetCompany(1).AddEmployee("Madhav Sharma", 22, "Part Time");
        
        compaines.GetCompany(0).ComputeEmployeeWage();
        compaines.GetCompany(1).ComputeEmployeeWage();
    }
}