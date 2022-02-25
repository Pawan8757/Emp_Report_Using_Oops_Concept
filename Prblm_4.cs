using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Report_Using_Oops
{
    public  class EmpChecking
    {
        public void UtilizingSwitchCase()
        {
           const int PartTime = 0;
           const int FullTime = 1;
           const int EmpPerHour = 20;
            int EmpHour = 0;
            int EmpWage = 0;

            Random random = new Random();   
            int number = random.Next(3);

            switch(number)
            {
                case PartTime:
                    EmpHour = 4;
                    break;

                    case FullTime:
                    EmpHour = 8;
                    break;

                    default:
                    EmpHour = 0;
                    break;

            }
            int EmpSalary = EmpHour * EmpPerHour;
              int total_EmpWage = EmpWage * EmpSalary;

            Console.WriteLine("Total salary would be " + total_EmpWage);
        }
    }
}
