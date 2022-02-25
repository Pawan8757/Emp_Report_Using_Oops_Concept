using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Report_Using_Oops
{
    public class EmpWageWithPartTime
    {
        public void CalculatingWages()
        {
            int EmpPerHour = 20;
            int PartTimeWorking = 8;
            int FullTimeWorking = 4;

            Random random = new Random();
            int number = random.Next(3);
            
            if (number == 0)
            {
                int EmpWage = EmpPerHour * PartTimeWorking;
                Console.WriteLine("EmpWage is " + EmpWage);
            }

            else if (number == 1)
            {
                int EmpWage = EmpPerHour * FullTimeWorking;
                Console.WriteLine("EmpWage is " + EmpWage);
            }

            else
            {
                Console.WriteLine("Nill");
            }

        }
    }
}
