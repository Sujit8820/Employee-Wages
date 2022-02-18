// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace Employee_Wages;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Wellcome to Employee Wage Program\n");

        EmployeeWageBuilder employeeWageBuilder = new EmployeeWageBuilder(2);
        employeeWageBuilder.AddEmployeeInfo("Tata", 20, 100, 20);
        employeeWageBuilder.AddEmployeeInfo("Dmart", 25, 125, 25);
        employeeWageBuilder.CalWage();
    }
}
