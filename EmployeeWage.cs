﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wages
{
     class  EmployeeWage
     {

        public static void EmpCheck()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);


            //Constants
            const int ABSENT = 0;


            if (empCheck == ABSENT)
            {
                Console.WriteLine("Employee is Absent");
            }
            else
            {
                Console.WriteLine("Employee is Present");
            }
        }
     }
}

