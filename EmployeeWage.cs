﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wages
{
     class  EmployeeWage
     {

        public static int EmpWage()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            int workingHrs = 0;


            //Constants
            const int ABSENT = 0;
            const int WAGEPERHRS = 20;


            if (empCheck == ABSENT)
            {
                workingHrs = 0;
                Console.WriteLine("Employee is Absent");
            }
            else
            {
                workingHrs = 8;
                Console.WriteLine("Employee is Present");
            }
            int empWage = WAGEPERHRS * workingHrs;
            return empWage;
            
        }
     }
}

