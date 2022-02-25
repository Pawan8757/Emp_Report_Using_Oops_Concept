using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Report_Using_Oops
{
    public class PerDayWage
    {
        public void CalculatingWages()
        {
            
            int WagePerHour = 20;
            int FullDaysHour = 8;
            int EmployeeWages;

            Random random = new Random();
            int number = random.Next(2);

            if (number == 1 )
            {
                EmployeeWages = WagePerHour * FullDaysHour;
                Console.WriteLine("Employee wages would be " + EmployeeWages);

            }

            else
            {
                Console.WriteLine("NILL");
            }
        }
    }
}
