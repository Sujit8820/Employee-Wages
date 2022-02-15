// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace Employee_Wages;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Wellcome to Employee Wage Program\n");

        int day = 0;
        int empTotalWage = 0;
        int MAXDAYS = 20;

        while (day < MAXDAYS)
        {
            int empWage = EmployeeWage.EmpWage();
            empTotalWage = empTotalWage + empWage;
            Console.WriteLine($"Employee day {day + 1} wage is {empWage}");
            day++;
        }
        Console.WriteLine("\nEmployee total wage is " + empTotalWage);

    }
}
