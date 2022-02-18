// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace Employee_Wages;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Wellcome to Employee Wage Program\n");

        EmployeeWage employeeWage1 = new EmployeeWage("Dmart", 20, 100, 20);
        EmployeeWage employeeWage2 = new EmployeeWage("Tata", 25, 125, 30);
        employeeWage1.GetEmpWage();
        employeeWage2.GetEmpWage();
    }
}
