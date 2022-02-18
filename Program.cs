// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace Employee_Wages;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Wellcome to Employee Wage Program\n");

        EmployeeWageBuilder dmart = new EmployeeWageBuilder("Dmart", 20, 100, 20);
        EmployeeWageBuilder tata = new EmployeeWageBuilder("Tata", 25, 125, 30);
        dmart.GetEmpWage();
        Console.WriteLine(dmart.ToString());
        tata.GetEmpWage();
        Console.WriteLine(tata.ToString());
    }
}
