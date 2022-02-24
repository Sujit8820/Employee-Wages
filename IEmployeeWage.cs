using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wages
{
    interface IEmployeeWage
    {
        public void AddEmployeeInfo(string companyName, int maxDay, int maxHrs, int wagePerHr);
        public void GetEmpWage(EmployeeWage employeeWages, string CompanyName);
        public void CalWage(string CompanyName);

    }
}
