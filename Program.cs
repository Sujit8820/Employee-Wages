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
        int workingHrs = 0;
        int totalWorkingHrs = 0;
        int empTotalWage = 0;
        int MAXDAYS = 20;
        int MAXHRS = 100;
        int WAGEPERHRS = 20;

        while (day < MAXDAYS && workingHrs < MAXHRS)
        {
            workingHrs = EmployeeWage.GetWorkingHrs();
            totalWorkingHrs = totalWorkingHrs + workingHrs;

            int empWage = WAGEPERHRS * workingHrs;
            empTotalWage = empTotalWage + empWage;

            Console.WriteLine($"Employee day {day + 1} wage is {empWage}");
            day++;
        }
        Console.WriteLine("\nTotal working hours is " + totalWorkingHrs);
        Console.WriteLine("Total employee wage is " + empTotalWage);

    }
}
