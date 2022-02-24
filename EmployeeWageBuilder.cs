using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wages
{
    class EmployeeWageBuilder : IEmployeeWage
    {
        int count = 0;

        ArrayList employeeWages = new ArrayList();

        // EmployeeWage[] employeeWages;

     /*   public EmployeeWageBuilder(int size)
        {
            this.employeeWages = new EmployeeWage[size];
        }*/
        public void AddEmployeeInfo(string companyName, int maxDay, int maxHrs, int wagePerHr)
        {
            employeeWages.Add(new EmployeeWage(companyName, maxDay, maxHrs, wagePerHr));
            /*this.employeeWages[count] = new EmployeeWage(companyName, maxDay, maxHrs, wagePerHr);
            count++;*/
        }

        public void CalWage()
        {
            foreach (var empWageObj in employeeWages)
            {
                GetEmpWage((EmployeeWage)empWageObj);

              /*  int totalWage = GetEmpWage(empWageObj);
                empWageObj.SetTotalEmpWage(totalWage);
                Console.WriteLine(empWageObj.ToString());*/
            }
        }
        public void GetEmpWage(EmployeeWage employeeWages)
        {
            int workingHrs = 0;
            int day = 0;
            int totalWorkingHrs = 0;
            int empTotalWage = 0;



            while (day < employeeWages.maxDay && totalWorkingHrs <= employeeWages.maxHrs)
            {

                Random random = new Random();
                int empCheck = random.Next(0, 3);

                //Constants
                const int ABSENT = 0;
                const int FULLTIME = 1;

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

                totalWorkingHrs = totalWorkingHrs + workingHrs;

                int empWage = employeeWages.wagePerHr * workingHrs;
                empTotalWage = empTotalWage + empWage;
                day++;
            }
           // return empTotalWage;


            employeeWages.SetTotalEmpWage(empTotalWage);
            Console.WriteLine( employeeWages.ToString());
        }



    }
}
