using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Report_Using_Oops
{
    public class MonthlySalary
    {
        public void CalculatingMonthlyWage()
        {
            const int PartTime = 0;
            const int FullTime = 1;
            const int EmpPerHour = 20;
            int wage = 0;
            int EmpHrs;
            int TotalWorkingDays = 20;
            int TotalSalary = 0;



            for (int i = 0; i <= TotalWorkingDays; i++)
            {
                Random random = new Random();
                int number = random.Next(3);
            
                if (number == PartTime)
                {
                     EmpHrs = 4;

                }

                else if (number == FullTime)
                {
                    EmpHrs = 8;
                }

                else
                {
                     EmpHrs = 0;
                }

                int EmpWages = EmpHrs * EmpPerHour;
                TotalSalary = (EmpWages + TotalSalary);

            }
            Console.WriteLine("Total Salary In A Month = " + TotalSalary);
        }

    }
}
