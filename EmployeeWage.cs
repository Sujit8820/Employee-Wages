using System;
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
                    break;

                case FULLTIME:
                    workingHrs = 8;
                    break;

                default:
                    workingHrs = 4;
                    break;
            }

            int empWage = WAGEPERHRS * workingHrs;
            return empWage;

        }
    }
}

