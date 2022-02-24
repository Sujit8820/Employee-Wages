// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace Employee_Wages;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Wellcome to Employee Wage Program\n");

        EmployeeWageBuilder employeeWageBuilder = new EmployeeWageBuilder();
        employeeWageBuilder.AddEmployeeInfo("Tata", 20, 100, 20);
        employeeWageBuilder.AddEmployeeInfo("Dmart", 25, 125, 25);
        employeeWageBuilder.AddEmployeeInfo("Reliance", 30, 140, 35);
        employeeWageBuilder.AddEmployeeInfo("BigBazar", 23, 110, 22);
        employeeWageBuilder.CalWage("Dmart");
    }
}
