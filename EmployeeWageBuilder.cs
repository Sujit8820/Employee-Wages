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

        ArrayList employeeWages = new ArrayList();

        public void AddEmployeeInfo(string companyName, int maxDay, int maxHrs, int wagePerHr)
        {
            employeeWages.Add(new EmployeeWage(companyName, maxDay, maxHrs, wagePerHr));

        }

        public void CalWage(string CompanyName)
        {

            foreach (var empWageObj in employeeWages)
            {
                GetEmpWage((EmployeeWage)empWageObj, CompanyName);

            }
        }
        public void GetEmpWage(EmployeeWage employeeWages, string CompanyName)
        {
            if (CompanyName == employeeWages.companyName)
            {
                Dictionary<int, int> dailyWage = new Dictionary<int, int>();

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

                    int empWage = employeeWages.wagePerHr * workingHrs;
                    empTotalWage = empTotalWage + empWage;
                    dailyWage.Add(day, empWage);

                    day++;
                }
                for(int i= 0; i < day; i++)
                {
                    Console.WriteLine($"day: {i+1}      wage: {dailyWage[i]}");
                }
                employeeWages.SetTotalEmpWage(empTotalWage);
                Console.WriteLine(employeeWages.ToString());
            }
        }


    }
}
