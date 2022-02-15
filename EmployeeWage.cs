﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wages
{
    class EmployeeWage
    {

        public static int EmpWage()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            int workingHrs = 0;


            //Constants
            const int ABSENT = 0;
            const int FULLTIME = 1;
            const int WAGEPERHRS = 20;


            switch (empCheck)
            {

                case ABSENT:
                    workingHrs = 0;
                    Console.WriteLine("Employee is Absent");
                    break;

                case FULLTIME:
                    workingHrs = 8;
                    Console.WriteLine("Employee is full time present");
                    break;

                default:
                    workingHrs = 4;
                    Console.WriteLine("Employee is part time present");
                    break;
            }

            int empWage = WAGEPERHRS * workingHrs;
            return empWage;

        }
    }
}

